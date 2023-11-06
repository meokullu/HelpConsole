## HelpConsole Changelog
[![CalculateETA](https://img.shields.io/nuget/v/HelpConsole.svg)](https://www.nuget.org/packages/HelpConsole/)

<!--
### [Unreleased]

#### Added

#### Changed

#### Removed
-->

### [1.0.0-beta.2]

#### Added
* `SetConsoleTitle(string firstText)` and `SetConsoleTitle(string firstText, string secondText)` new methods are added. These methods calls `SetConsoleTitle(strinf firstText, string secondText, string thirdText)`. 

#### Changed
* New design README.
* New design CHANGELOG.

### [1.0.0-beta.1]

### Changed
* Changing missing static declaration into `Beep`, `Math`, `ScreenColorOption`.
* Changing wrong namespace on `Method`, `ScreenColorOption` and `Title`.

### [1.0.0-beta]

### Added
* New pre-defined `ScreenColorOption`. `ScrenColorOptionCyan` and `ScreenColorOptionDarkYellow` are added.
* `Beep(Melody)` is added.
* `Melody` added. Melody has array of integers which is played by `Beep(Melody)`. Integers address sound frequency, duration of sound and waiting respectively.
* `Warning`, `Welcome`, `Success` pre-defined `Melody` are added.

### Changed
* `Beep.cs` is created.
* `Math.cs` is created.
* `Title.cs` is created.
* `ScreenColorOption.cs` is created.

### [1.0.0-alpha.5]

### Added
* `ConsoleOption` is available now. It has `AppName`, `ScreenColorOption`, `CursorAvailable`, `WarningSound` and `WaitOnEnd` properties.
* `ScreenColorOption` has `BackgroundColor` and `ForegroundColor` and its constructor.
* Missing method summaries are filled.

### Changed
* Beeping as warning has condition which is set to be false as default.

### Removed
* `FinishingUp()` method is depreciated and renamed as `FinishUp()`.
* `StartUp(string appName)` method is depreciated. Use `StartUp()`

### [1.0.0-alpha.4]

#### Added
* Tag added to PackageTags.
* CHANGELOG link added under Version History on README.

#### Changed
* README has cleaner view.

### [1.0.0-alpha.3]

#### Added
* Added icons.

### [1.0.0-alpha.2]

#### Added
* Added summaries into methods.
* Added comments.

### [1.0.0-alpha.1]

#### Added
* Added `ClearConsoleTitle()`.
* Added `Percentage8F()` for `double`, `short`, `byte`, `sbyte`.

### [1.0.0-alpha]
* Initial version.