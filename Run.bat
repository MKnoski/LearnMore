@echo OFF

ECHO Running Angular...
ECHO.
cd LearnMore.Angular\
START ng serve --watch false
cd ..

ECHO Building Dotnet...
ECHO.
cd LearnMore.Api\
START dotnet run 
cd ..
