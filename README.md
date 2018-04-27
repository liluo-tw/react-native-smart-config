
# react-native-smart-config

## Announcement

Still underdevelopment. Would update the announcement when it's ready.

## Getting started

`$ npm install react-native-smart-config --save`

### Mostly automatic installation

`$ react-native link react-native-smart-config`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-smart-config` and add `RNSmartConfig.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSmartConfig.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.luoli.smartconfig.RNSmartConfigPackage;` to the imports at the top of the file
  - Add `new RNSmartConfigPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-smart-config'
  	project(':react-native-smart-config').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-smart-config/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-smart-config')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNSmartConfig.sln` in `node_modules/react-native-smart-config/windows/RNSmartConfig.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Smart.Config.RNSmartConfig;` to the usings at the top of the file
  - Add `new RNSmartConfigPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNSmartConfig from 'react-native-smart-config';

// TODO: What to do with the module?
RNSmartConfig;
```
  