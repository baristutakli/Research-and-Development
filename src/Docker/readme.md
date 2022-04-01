# Docker Katas

* syntax=docker/dockerfile:1
```
FROM node:12-alpine
RUN apk add --no-cache python2 g++ make
WORKDIR /app
COPY . .
RUN yarn install --production
CMD ["node", "src/index.js"]
EXPOSE 3000

```
#### Build an image
```
docker build -t getting-started .
```

* "yarn" is used to install the application's dependencies
* The "CMD" directive specifies the default command
* "-t" flag tags our image
* The "." identifies the location of the dockerfile in the current directory

#### Start an app container

```
docker run -dp 3000:3000 getting-started
```

* -d: detached
* -p: port
* 3000:3000  host port and container port
* "getting-started: name of the container

#### How to get the Id of a container
```
docker ps
```
#### How to stop a container
```
docker stop <container-id>
```
#### How to remove a container
```
docker rm <the-container-id>
```
#### How to get the Id of a container
```
docker ps
```