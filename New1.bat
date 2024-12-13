@echo off
rem A simple batch file for New1 C# program
rem which captures the app return value

.\New1
@if "%ERRORLEVEL%" == "0" goto success

:fail
    echo This application has failed!
    echo Return value == "%ERRORLEVEL%"
    goto end

:success
    echo This application has succeded!
    echo Return value == "%ERRORLEVEL%"
    goto end

:end
echo all done.