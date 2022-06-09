# Mango Development Database Docker Image

## Prerequisites

- [Docker](https://www.docker.com/get-started/)
- [Azure CLI](https://docs.microsoft.com/pl-pl/cli/azure/install-azure-cli)
- [WSL 2](https://docs.microsoft.com/en-us/windows/wsl/install-win10)

## Running image

Running database image is pretty simple.
First, authenticate with DockerHub Container registry by running following command:

```sh
docker login docker.io -u <user_name> -p <password>
```

Once this is done simply run following:

```sh
docker run -e 'SA_PASSWORD=x2yiJt!Fs' --name mango-mssql-db -p 1433:1433 -d docker.io/mango-mssql-db:latest
```

| Parameter      | Description                                                                                                          |
|----------------|----------------------------------------------------------------------------------------------------------------------|
| -e SA_PASSWORD | environment variable containing SA db user password - can be altered to any value                                    |
| --name         | name of the container                                                                                                |
| -p             | port under which database is exposed - modify to 1433:<different_port> if already using 1433 for SQL Server Instance |

## Building Image and Pushing to Container Registry

By default, the `mango-mssql-db` will expose the port 1433, so change this within the Dockerfile if necessary.
When ready, simply use the Dockerfile to build the image. Modify `CONTAINER_IMAGE_VERSION` if base version of the image
gets modified.

```sh
export CONTAINER_REGISTRY_NAME="docker"
export CONTAINER_REGISTRY_FQDN="$CONTAINER_REGISTRY_NAME.io"
export CONTAINER_REPOSITORY_NAME="mango-mssql-db"
export CONTAINER_IMAGE_VERSION="1.X"
export CONTAINER_IMAGE_TAG="mango-mssql-db-$CONTAINER_IMAGE_VERSION"

# Log into your Azure Container Registry  
docker login docker.io -u <user_name> -p <password>

# Build the image and push to the registry
docker build -t $CONTAINER_REPOSITORY_NAME:$CONTAINER_IMAGE_TAG ./build/docker/mssql-docker/
docker tag $CONTAINER_REPOSITORY_NAME:$CONTAINER_IMAGE_TAG "$CONTAINER_REGISTRY_FQDN/$CONTAINER_REPOSITORY_NAME:$CONTAINER_IMAGE_TAG"
docker tag $CONTAINER_REPOSITORY_NAME:$CONTAINER_IMAGE_TAG "$CONTAINER_REGISTRY_FQDN/$CONTAINER_REPOSITORY_NAME:""latest"
docker tag $CONTAINER_REPOSITORY_NAME:$CONTAINER_IMAGE_TAG petrokolosov/mango-mssql-db:latest
docker image push petrokolosov/mango-mssql-db:latest

```