resource "random_uuid" "random_id" {}

resource "random_string" "sql_password" {
  length           = 20
  special          = true
  override_special = "!@#$%&*()-_=+[]{}<>:?"
  min_special      = 2
  min_upper        = 2
  min_lower        = 5
  min_numeric      = 3
}