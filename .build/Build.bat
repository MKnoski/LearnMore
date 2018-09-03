@echo OFF
cd ..

cd LearnMore.Angular\

GOTO RESTORE_NPM

:RESTORE_NPM
ECHO Restoring NPM...
ECHO.
npm install | more
GOTO BUILD_ANGULAR

:BUILD_ANGULAR
ECHO Building Angular...
ECHO.
ng build | more

cd ..

GOTO BUILD_DOTNET

:BUILD_DOTNET
ECHO Building Dotnet...
ECHO.
cd LearnMore.Api\
dotnet build | more
cd ..

EXIT