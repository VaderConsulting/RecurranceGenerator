# RecurranceGenerator

C# library that builds lists of recurrence dates: daily, weekly, monthly, and yearly, with optional end date or occurrence count. `RecurrenceMananger` (BOCA.RecurrenceGenerator) is the entry point. RecurrenceTester is a WinForms host (`DateTester`) that shows generated dates and a pattern-definition viewer. The OneDrive folder name keeps the original misspelling; project names use Recurrence.

**Source last updated:** 2013-08-23  
**Language:** C#  
**Target:** .NET 3.5  
**Output:** class library + WinForms tester exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `RecurrenceGenerator` | C# | class library (.NET 3.5) | Daily/weekly/monthly/yearly recurrence date lists |
| `RecurrenceTester` | C# | WinForms exe (.NET 3.5) | DateTester host and pattern viewer |

## How to open

Open `RecurrenceGenerator.sln` in Visual Studio 2012 or later. Run RecurrenceTester.

## Requirements

- Visual Studio 2012, .NET Framework 3.5

## Attribution and provenance

From Dave Robinson's Historical Dev archive (OneDrive folder `RecurranceGenerator`). Namespaces mix `RecurrenceGenerator` and `BOCA.RecurrenceGenerator`. Assembly copyright fields are empty. See `THIRD_PARTY_NOTICES.md`.

## License

MIT License. Copyright (c) 2026 VaderConsulting. Library origin is a working copy; see `THIRD_PARTY_NOTICES.md`.
