# LotSS Roadmap

## Objectives

### Editor 
#### Primary
Create an easy to use Editor capable of modifying most of the games core functionality, allowing content to be modified. 

#### Secondary
Aspirationally, support a foundation which allows more advanced reverse engineering, such as discovery of future mods. Provide the ability to add and remove content through other means, while allowing the Editor to support supplemental changes to core functionality.

### Game
#### Overhaul Patch
Meant to fix up the games balance and allow some new content to improve the overall experience without changing the entire game. 

##### Intent

* Favor replacing repetitive content with new content.
* Favor using movies and filler characters over creating new ones.
* Favor using unused content, rather than just adding new content.
* Favor making early game easier, and late game harder.
* Favor allowing all playable characters to be useful.

## Deliverables

### Editor
#### Will Do
* Make all editor addresses configurable from definition.
* Implement dynamic module loading to easily move addresses when user requests to add, delete or heavily modify content.
* Implement editor features necessary to allow modifications to the Game for the Overhaul patch.
	* Skill Effects Editing (Visual and Functional)
	* Map Objects Editing
	* Random Encounter Editing

### Game (Overhaul Patch)
#### Will Do
* **Max Levels**: All characters have 50 levels with Max Battle Power (BP):
  * **Goku**: 300k (6M with Kaioken x20)
  * **Piccolo**: 2M
  * **Gohan**: 1.7M
  * **Krillin**: 1.6M
  * **Yamcha**: 1.6M
  * **Tien**: 1.8M
  * **Chiaotzu**: 1.5M
  * **Vegeta**: 2M
* **Secret Fight Update**: SSJ Future Trunks (16M BP) replaces SSJ Vegeta.
  * Battler and skills added (Finish Buster, Burning Attack).
  * Base & SSJ sprites and palette added.
  * Battler and skill text added.
  * Ending dialogue changed.
* **New Enemies**: 3 new enemies with unique sprites (500k-1M BP, 5k-15k XP).
* **Transformations**: Level 51 triggers transformation (SSJ/Fusion).
* **Transformation Table**: Moved and expanded with space for all levelable characters.
  * **SSJ Goku**: 10M
  * **SSJ Vegeta**: 9M
  * **SSJ Gohan**: 8M
  * **Piccolo Fused**: 6M (with Dende, Tsumari & Maima) $\rightarrow$ Can powerup to 9M.
* **Skills**: New SSJ Transformation skill uses the transformation table.
* **Fixes & Balances**:
  * Translation errors fixed.
  * Random encounters rate reduced.
* **Boss Substitutions**:
  * Fake Raditz is replaced by Garlic Jr.
  * Fake Frieza is replaced by Lord Slug.
  * Mr. Popo enemies are replaced by Cinnamon, Ginger, and Nikki.
* **Visuals**: Frieza 100% sprite added and used in battler.

#### Nice to Have
* **Optional Fight**: Dr. Wheelo found on map before Nappa fight.
* **Bonus Boss**: Turles fight right before going to Namek.

---

## Specifications

### Editor - Dynamic Module Format

#### Address 0x100000 - 0x10009F
* **Size**: 255 Bytes (Header)
* **Validation**: If first 12 bytes match `4C 6F 74 53 53 20 45 64 69 74 6F 72`, the file **Is Managed**. Otherwise, it is **Unknown**.

#### Address 0x100100 - 0x100500
* **Byte 1**: Module Identifier
  * `0`: Unknown
  * `1`: Data
  * `150`: Text
  * `170`: Sprite
  * `200`: Palette
  * `220`: Audio
* **Bytes 2–4**: 3-Byte Module Absolute Address
* **Early End**: `FFFF`

*...Next Module/s*

---

## Possible Ideas

* Item effects can be modified.
* Shops and their inventories can be modified.
