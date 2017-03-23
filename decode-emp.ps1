function decode-emp{
[cmdletbinding()]

Param([parameter(Mandatory=$true,position=0)]
[string]$file)

[string]$content = (([IO.File]::ReadAllText($file)) -split "3000")
[string]$decodedArray = ''
$content.split() | %{if($_ -cmatch '[a-z]'){
            $decodedArray += $_.toupper()}
        elseif($_ -cmatch '[A-Z]'){
            $decodedArray += $_.tolower()}
        elseif($_ -eq " "){
            pass}
 
    }
           write-host $decodedArray
}
