# Console Tools Arguments - Release Procedure

## Before Starting

- Checkout the master branch.
- Verify the content of the `doc\readme.txt` file.
- Verify the content of the `doc\changelog.txt` file.
- Verify the version to be consistent in all files:
  - `doc\readme.txt` file;
  - `doc\changelog.txt` file;
  - `sources\Directory.build.props` file;
  - `release\ConsoleTools.Commando.proj` file.

## Step 1 - Create the release

- Open a Developer Command Prompt for Visual Studio.
- Run the `ConsoleTools.Arguments.proj` file:

```
msbuild ConsoleTools.Arguments.proj
```

The resulted files are located in the `output` directory.

## Step 2 - Increment version

Increment the version in all files:

- `doc\readme.txt` file;
- `doc\changelog.txt` file;
- `sources\Directory.build.props` file;
- `release\ConsoleTools.Arguments.proj` file.
