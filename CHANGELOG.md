## HelpConsole Changelog
[![HelpConsole](https://img.shields.io/nuget/v/HelpConsole.svg)](https://www.nuget.org/packages/HelpConsole/)

<!--
### [Unreleased]

#### Added

#### Changed

#### Removed
-->

### [1.0.0]
Initial release.

### Changed
* `Welcome`, `Warning`, `Success`, melody in `StartUp()` and `FinishUp()` are replaced with new ones.

### [1.0.0-rc]

#### Added
* `SetScreenColor(ScreenColorOption screenColorOption)` method is added. It sets console colors as method.
* `ShowAvailableColors()` method is added. It list available color-pairs on screen.

#### Changed
* `StartUp(ConsoleOption consoleOption)` calls `SetScreenColor(ScreenColorOption screenColorOption)` instead of setting Console.BackgroundColor and Console.ForegroundColor individually.

#### Removed
* `StartUp(string appname)` deprecated method is removed. Use `StartUp(ConsoleOption consoleOption)`.
* `FinishingUp()` deprecated method is removed. Use `FinishUp()`.

### [1.0.0-beta.4]

#### Added
* `SetConsoleTitleSeperator(string separator)` is added. Console title's item could be seperated with provided value.

#### Changed
* `SetConsoleTitleSeperator(string firstText, string secondText, string thirdText)` is now checking if parameter is provided and if so adds string seperator value.

### [1.0.0-beta.3]

#### Added
* `SetStartMethodMelody(Melody melody)` and `SetEndingMethodMelody(Melody melody)` are added for `Method.cs`. These methods can be used to set default melody that will be played when `StartMethod()` and `EndingMethod()` are called respectively.
* `Beeping(duration)` method is added.

#### Changed
* `StartMethod()` and `EndingMethod()` are no longer use `Console.Beep()`. These methods are now using `Beep(Melody melody)` under `Beep.cs`.
* Calling `Console.Title()` is replaced with `SetConsoleTitle()` method.
* Calling `Console.Beep()` is replaced with `Beep(Melody melody)` method.
* Added cref method references into method summaries.

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