param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $planPath
)

Write-Host "Terraform plan path : $planPath"

$plan = $( terraform show -json "$planPath" | ConvertFrom-Json )

$actions = $plan.resource_changes.change.actions

if (($actions -contains 'create') -or ($actions -contains 'delete') -or ($actions -contains 'update'))
{
    Write-Host "There are changes detected in terraform plan."
    Write-Host "##vso[task.setvariable variable=anyTfChanges;]true"
}
else
{
    Write-Host "There are no changes detected in Terraform tfplan file"
}

# example call: ./checkTerraformChanges.ps1 -planPath "../terraform/main.tfplan"
# example call: ./checkTerraformChanges.ps1 -planPath "D:\RiderProjects\MangoMessengerAPI\terraform\main.tfplan"
# example call: ./../scripts/checkTerraformChanges.ps1 -planPath "D:\RiderProjects\MangoMessengerAPI\terraform\main.tfplan"