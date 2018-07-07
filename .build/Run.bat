@echo OFF

ECHO Running Angular... ^(watch mode^) 
ECHO.
cd LearnMore.Angular\
START npm start
cd ..

ECHO Building Dotnet... ^(watch mode^) 
ECHO.
cd LearnMore.Api\
START dotnet watch run
cd ..