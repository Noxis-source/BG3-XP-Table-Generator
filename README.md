# BG3 XP Table Generator

![](main.png)

This is a simple tool that generates expereince and treasure tables (Data.txt, XPData.txt, ExperienceRewards.lsx, and TreasureTable.txt) for Baldur's Gate 3 in the required format.

## Requirements

[.NET 7 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## How-To

1. Enter the required maximum XP number (the game's default is 200000);
2. Enter the required number of levels (the game's default is 12);
3. Click Generate;
4. Analyze generated data. You can adjust numbers in the grid if something looks off (especially early levels);
5. Optionally, edit XP rewards for various actions in the game or the treasure table;
6. Click Export and select an export location.

You'll find generated files in the set location.

## What's Next?

Set LSLib (divine.exe) path in Settings and click pack to select the generated folder and package your mod. Alternatively, just
use [BG3 Modder's Multitool﻿](https://github.com/ShinyHobo/BG3-Modders-Multitool).

## P.S.

This tool uses simple and straightforward progression curves. If you feel like you can come up with another solution, please feel free to submit a pull request.
