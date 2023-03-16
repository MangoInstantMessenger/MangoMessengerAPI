output "jwt_sign_guid" {
  value     = random_uuid.random_id.result
  sensitive = true
}

output "sql_password" {
  value     = random_string.sql_password.result
  sensitive = true
}