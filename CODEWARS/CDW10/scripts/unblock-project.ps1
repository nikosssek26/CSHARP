Param(
    [string]$Path = "."
)

$fullPath = Resolve-Path -Path $Path
Write-Host "Unblocking files under $fullPath"

# Try Unblock-File for every file; fallback to removing Zone.Identifier ADS when necessary
Get-ChildItem -Path $fullPath -Recurse -Force -File -ErrorAction SilentlyContinue | ForEach-Object {
    try {
        Unblock-File -Path $_.FullName -ErrorAction SilentlyContinue
    } catch {
        try {
            $ads = "$($_.FullName):Zone.Identifier"
            if (Test-Path -LiteralPath $ads) {
                Remove-Item -LiteralPath $ads -ErrorAction SilentlyContinue
            }
        } catch {}
    }
}

Write-Host "Completed. Clean and rebuild the solution if necessary."