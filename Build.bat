@echo OFF

ECHO Building Angular...
ECHO.
cd LearnMore.Angular\
ng build | more
cd ..

ECHO Building Dotnet...
ECHO.
cd LearnMore.Api\
dotnet build | more
cd ..
