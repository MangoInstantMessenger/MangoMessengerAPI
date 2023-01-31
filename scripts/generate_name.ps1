 function Get-RandomCharacters($length, $characters) {
        $random = 1..$length | ForEach-Object { Get-Random -Maximum $characters.length }
        $private:ofs=""
        return [String]$characters[$random]
 }

 function Scramble-String([string]$inputString){     
    $characterArray = $inputString.ToCharArray()   
    $scrambledStringArray = $characterArray | Get-Random -Count $characterArray.Length     
    $outputString = -join $scrambledStringArray
    return $outputString 
  }
  
  $rndname = Get-RandomCharacters -length 10 -characters 'abcdefghiklmnoprstuvwxyz'
  $rndname += Get-RandomCharacters -length 5 -characters '1234567890'
  
  $rndname = Scramble-String $rndname

  $DeploymentScriptOutputs = @{}
  $DeploymentScriptOutputs['rndname'] = $rndname