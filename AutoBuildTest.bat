rem @echo off

cd StaticCodeAnalyser\StaticCodeAnalyser
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\msbuild.exe" StaticCodeAnalyser.vcxproj /p:configuration=debug	
Debug\StaticCodeAnalyser.exe

rem cd ..\StaticCodeAnalyserTest
rem "C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\msbuild.exe" StaticCodeAnalyserTest.vcxproj /p:configuration=debug	
rem Debug\StaticCodeAnalyserTest.exe

echo Error code is %errorlevel%

pause