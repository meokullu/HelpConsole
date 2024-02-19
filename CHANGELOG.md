## HelpConsole Changelog
[![HelpConsole](https://img.shields.io/nuget/v/HelpConsole.svg)](https://www.nuget.org/packages/HelpConsole/)

<!--
### [Unreleased]

#### Added

#### Changed

#### Removed
-->

### [1.5.0]
#### Added
* `Write<T>(T value, ConsoleColor color, Melody melody)` method is added. You can call it to write colorful text with beeping.
* `WriteLine<T>(T value, ConsoleColor color, Melody melody)` method is added. You can call it to write colorful text with beeping into new line.
* Added `Notes` null check under `Melody` when `Beep(Melody melody)` is called.

#### Fixed
* `StartUp()` was throwing an error when consoleOption is not provided as value. When value is not provided, it creates ConsoleOption but `ScreenColorOption` was not set any value. Now it has its default value when value is not provided into `StartUp()`
#### Changed

* `Beep(Melody melody)` was writing simple "error on notes" when frequency-beeping duration-waiting duration pair has argument range error. Now it checks frequency's range (32-32767) and beeping/duration positivity individually. It writes specified index/indexes on screen.
* Variable naming is fixed under `Title.cs`
* `Beep.cs`, `Math.cs`, `Method.cs`, `ScreenColorOption.cs` and `Title.cs` are not longer static classes.
* Naming error are fixed on private static variables on `Title.cs`

### [1.4.0]

#### Added
* `StartingMethod(Melody melody, [CallerMemberName] string memberName = "")`
* `StartingMethod(ConsoleColor color, Melody melody, [CallerMemberName] string memberName = "")`
* `EndingMethod(Melody melody, [CallerMemberName] string memberName = "")`
* `EndingMethod(ConsoleColor color, Melody melody, [CallerMemberName] string memberName = "")`
* `Write<T>(T value, Melody melody)`
* `Write<T>(List<T> valueList, T expectedValue, Melody melody, ConsoleColor valueColor, ConsoleColor expecetedColor)`
* `WriteLine<T>(T value, Melody melody)`
* `WriteLine<T>(List<T> valueList, T expectedValue, Melody melody, ConsoleColor valueColor, ConsoleColor expectedColor)`

### [1.3.0]
#### Added
* `StartingMethod(ConsoleColor consoleColor, [CallerName] string memberName = "")` method is added. Now `StartingMethod()` writes method's start with colorful text.
* `EndingMethod(ConsoleColor consoleColor, [CallerName] string memberName = "")` method is added. Now `EndingMethod()` writes method's end with colorful text.
* `Black`, `DarkBlue`,`DarkGreen`, `DarkDyan`, `DarkRed`, `DarkMagenta`, `DarkYellow`, `Gray`, `DarkGray`, `Blue`, `Green`, `Cyan`, `Red`, `Magenta`, `Yellow` and `White` are added as `ConsoleColor` to use them easily on `Write<T>()` and `WriteLine<T>()`.

#### Changed
* `ScreenColorOptions` was not holding color-pair, now it is fixed.
* When `SetScreenColor(ConsoleColor foregroundColor, ConsoleColor backgroundColor)` called, now it also sets `ScreenColorOptions` which holds preset values.
* `ConsoleOptions` was not holding options, now it is fixed.
* When `StartUp(ConsoleOption consoleOption)` called, now it also sets `ConsoleOptions` which holds preset option values.
* When `StartUp(ConsoleOption consoleOption)` called, now it also sets `ScreenColorOption` which holds preset color-pair values with given `ScreenColorOption` on `consoleOptions`.

### [1.2.0]

#### Added
* `Write<T>(T value, ConsoleColor color)` method added.
* `Write<T>(List<T> valueList, T expectedValue, ConsoleColor valueColor, ConsoleColor expectedColor)` method added.
* `WriteLine<T>(T value, ConsoleColor color)` method added.
* `WriteLine<T>(List<T> valueList, T expectedValue, ConsoleColor valueColor, ConsoleColor expectedColor)` method added.

### [1.1.1]

#### Changed
v1.1.1
* Bux fixed while lsting color combinations names as background and foreground by `ShowAvailableColors()` under `ScreenColorOptions.cs`
* Color issues are fixed while listing color combinations by `ShowAvailableColors()

### [1.1.0]

#### Changed
* `StartUp(ConsoleOption consoleOption)` method was using default `ScreenColorOption` instead of given value on `ConsoleOption`. This bug is fixed.
* `StartingMethod()` and `EndingMethod()` had new line before writing either calling method name's starting or ending. This new line addings are removed on both methods.

### [1.0.0]
Initial release.

#### Changed
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