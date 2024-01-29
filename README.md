## HelpConsole
[![HelpConsole](https://img.shields.io/nuget/v/HelpConsole.svg)](https://www.nuget.org/packages/HelpConsole/) [![HelpConsole](https://img.shields.io/nuget/dt/HelpConsole.svg)](https://www.nuget.org/packages/HelpConsole/) [![License](https://img.shields.io/github/license/meokullu/HelpConsole.svg)](https://github.com/meokullu/HelpConsole/blob/master/LICENSE)

HelpConsole is a project to offer useful methods which makes easier to use console applications.

![HelpConsole](https://github.com/meokullu/HelpConsole/assets/4971757/b90993c5-ffa8-4f59-9255-127f4871794a)

[Download on NuGet gallery](https://www.nuget.org/packages/HelpConsole/)

### Description

HelpConsole has methods to increase liability of output, state and methods.

### Example Usage

#### Start & Finish
```
StartUp(ConsoleOption consoleOption = null);
```
```
FinishUp()
```
#### Text
```
SetConsoleTitle(string firstText = "", string secondText = "", string thirdText = "")
```
```
ClearConsoleTitle()
```
```
Write<T>(T value, ConsoleColor color);
```
```
Write<T>(List<T> valueList, T expectedValue, ConsoleColor valueCcolor, ConsoleColor expectedColor);
```
#### Sleeping & Beeping
```
Beep(Melody melody)
```
```
Sleep(int duration)
```
```
SleepWithBeeping(int duration)
```
#### Methods
```
StartingMethod([CallerMemberName] string memberName = "")
```
```
EndingMethod([CallerMemberName] string memberName = "")
```
#### Fractions
```
PercentageNoFrac(int item1, int item2)
```
```
Percentage2F(int item1, int item2)
```
```
Percentage8F(int item1, int item2)
```

To check listed methods, example of output visit wiki page. [HelpConsole Wiki](https://github.com/meokullu/HelpConsole/wiki)

### Version History
See [Changelog](https://github.com/meokullu/HelpConsole/blob/master/CHANGELOG.md)

### Task list
* Create an issue or check task list: [Issues](https://github.com/meokullu/HelpConsole/issues)

### Licence
This repository is licensed under the "MIT" license. See [MIT license](https://github.com/meokullu/HelpConsole/blob/master/LICENSE).

### Authors & Contributing

If you'd like to contribute, then contribute. [contributing guide](https://github.com/meokullu/HelpConsole/blob/master/CONTRIBUTING.md)

[![Contributors](https://contrib.rocks/image?repo=meokullu/HelpConsole)](https://github.com/meokullu/HelpConsole/graphs/contributors)

### Help
Twitter: Enes Okullu [@enesokullu](https://twitter.com/EnesOkullu)
