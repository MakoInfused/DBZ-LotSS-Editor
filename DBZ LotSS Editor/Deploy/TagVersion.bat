@echo off
setlocal enabledelayedexpansion

:: FORCE WINDOW TO STAY OPEN IF DOUBLE-CLICKED
echo %cmdcmdline% | findstr /i /c:"/c" >nul
if %errorlevel%==0 (
    cmd /k ""%~f0" %*"
    exit /b
)

:: Call the main logic block
call :MAIN

:: The script returns here after completing or encountering an error
echo.
echo ======================================================
echo Work complete. You can close this window now.
exit /b 0


:: ========================================================
:: MAIN PROCESS LOGIC
:: ========================================================
:MAIN
:: 1. CONFIGURATION
set "PROJECT_FILE=..\DBZ LotSS Editor.csproj"

:: 2. CHECK PREREQUISITES
if not exist "%PROJECT_FILE%" (
    echo [ERROR] Project file not found at: %PROJECT_FILE%
    echo Please ensure the script is running from the correct subdirectory.
    goto :EOF
)

git rev-parse --is-inside-work-tree >nul 2>&1
if %errorlevel% neq 0 (
    echo [ERROR] Current directory is not a Git repository.
    goto :EOF
)

:: 3. EXTRACT FILEVERSION USING POWERSHELL
echo Extracting FileVersion from DBZ LotSS Editor.csproj...

:: Cleanly execute PowerShell to extract the FileVersion property
set "PS_CMD=[xml]$x = Get-Content '%PROJECT_FILE%'; if ($x.Project.PropertyGroup.FileVersion) { $x.Project.PropertyGroup.FileVersion } else { (Select-String -Path '%PROJECT_FILE%' -Pattern '<FileVersion>(.*?)</FileVersion>').Matches.Groups.Value }"

for /f "usebackq delims=" %%i in (`powershell -NoProfile -Command "%PS_CMD%"`) do (
    set "VERSION=%%i"
)

:: Clean any trailing/leading whitespaces
if defined VERSION set "VERSION=%VERSION: =%"

if "%VERSION%"=="" (
    echo [ERROR] Could not find ^<FileVersion^> inside the project file.
    goto :EOF
)

echo Found version: v%VERSION%

:: 4. GIT TAGGING
git rev-parse "v%VERSION%" >nul 2>&1
if %errorlevel%==0 (
    echo [WARNING] Tag v%VERSION% already exists. Skipping tagging to prevent overwriting.
    goto :PROMPT_PUSH
)

echo Tagging latest commit with v%VERSION%...
git tag "v%VERSION%"

if %errorlevel% neq 0 (
    echo [ERROR] Failed to create git tag.
    goto :EOF
)

echo [SUCCESS] Successfully tagged latest commit with v%VERSION%

:: 5. INTERACTIVE PUSH PROMPT
:PROMPT_PUSH
echo.
set /p "CHOICE=Do you want to push tag v%VERSION% to origin? (y/n): "

if /i "%CHOICE%"=="y" (
    echo Pushing tag v%VERSION% to remote...
    git push origin "v%VERSION%"
    
    if !errorlevel!==0 (
        echo [SUCCESS] Tag pushed successfully.
    ) else (
        echo [ERROR] Failed to push tag to remote.
    )
) else (
    echo Push skipped.
)

:: Jump to End-Of-File for the main block to return control back to the top
goto :EOF
