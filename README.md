
# react-native-simple-youtube

## Getting started

`$ npm install react-native-simple-youtube --save`

### Mostly automatic installation

`$ react-native link react-native-simple-youtube`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-simple-youtube` and add `RNSimpleYoutube.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSimpleYoutube.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.danielwilhelmsen.RNSimpleYoutubePackage;` to the imports at the top of the file
  - Add `new RNSimpleYoutubePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-simple-youtube'
  	project(':react-native-simple-youtube').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-simple-youtube/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-simple-youtube')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNSimpleYoutube.sln` in `node_modules/react-native-simple-youtube/windows/RNSimpleYoutube.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Simple.Youtube.RNSimpleYoutube;` to the usings at the top of the file
  - Add `new RNSimpleYoutubePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNSimpleYoutube from 'react-native-simple-youtube';

// TODO: What to do with the module?
RNSimpleYoutube;
```
  