[CmdletBinding()]
param(
    [Parameter(ValueFromRemainingArguments)]
    [string[]]$Arguments
)

$ScriptDir = ([IO.Path]::GetDirectoryName($MyInvocation.MyCommand.Source))
$CommonProjectPath = ([IO.Path]::Join($ScriptDir, "..\SCHALE.Common\SCHALE.Common.csproj"))
$GameServerProjectPath = ([IO.Path]::Join($ScriptDir, "..\SCHALE.GameServer\SCHALE.GameServer.csproj"))

if ($Arguments.Length -lt 1 -Or $Arguments[0].Equals("-h") -Or $Arguments[0].Equals("--help"))
{
    Write-Output @"
Commands
    -h|--help   shows this help output
    undo        expands to dotnet ef migrations remove, undo latest migration
    create      expands to dotnet ef migrations add, second positional argument will be the migration name

Examples
    migrate.ps1 create Test
    migrate.ps1 undo
"@
exit
}

Switch ($Arguments[0])
{
    "undo"
    {
        dotnet ef migrations remove  --project $CommonProjectPath --startup-project $GameServerProjectPath --context SCHALEContext
    }
    "create" 
    {
        dotnet ef migrations add $Arguments[1] --project $CommonProjectPath --startup-project $GameServerProjectPath --context SCHALEContext
    }
    default
    {
        Write-Host "Invalid operation" $Arguments[0]
    }
}