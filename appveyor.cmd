@setlocal
@set _P=%~dp0
@if "%CONFIGURATION%"=="" set CONFIGURATION=Debug

@pushd %_P%

dotnet pack .\src\AppSyndication.Shared.Models --configuration %CONFIGURATION% --output %_P%artifacts\public

@goto :End

Fail:
@echo Must provide build number.
@exit /b -1

:End
@popd
@endlocal
