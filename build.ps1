Param ($Version = "1.0-dev")
$ErrorActionPreference = "Stop"
pushd $PSScriptRoot

src\build.ps1 $Version
doc\build.ps1 $Version

popd
