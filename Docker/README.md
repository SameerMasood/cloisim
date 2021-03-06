# Running CLOiSim in Docker

This folder contains Dockerfile and instructions to run pre-built CLOiSim in container.
Dockerfile creates minimal image with Vulkan capabilities, and downloads latest release version of CLOiSim.

## Prerequisite

Make sure you if NVIDIA Container Toolkit is already installed on your machine.

```shell
distribution=$(. /etc/os-release;echo $ID$VERSION_ID)
curl -s -L https://nvidia.github.io/nvidia-docker/gpgkey | sudo apt-key add -
curl -s -L https://nvidia.github.io/nvidia-docker/$distribution/nvidia-docker.list | sudo tee /etc/apt/sources.list.d/nvidia-docker.list

sudo apt-get update && sudo apt-get install -y nvidia-container-toolkit
sudo systemctl restart docker
```

It may differ from latest guide.

Refer here for install guide [nvidia-docker](https://github.com/NVIDIA/nvidia-docker).

## Run Docker

### build docker image

Run following command to build a image:

```shell
docker build -t cloisim .
```

### run docker container

#### Option A

Use following command to run CLOiSim docker container:

```shell
export CLOISIM_RESOURCES_PATH=/home/closim/SimulatorInstance/sample-resources/

docker run -ti --rm --gpus all --net=host \
    -e DISPLAY \
    -v ${XAUTHORITY}:/tmp/.Xauthority \
    -e XAUTHORITY=/tmp/.Xauthority \
    -v /tmp/cloisim/unity3d:/root/.config/unity3d \
    -v /tmp/.X11-unix:/tmp/.X11-unix  \
    -v ${CLOISIM_RESOURCES_PATH}/materials:/opt/resources/materials/ \
    -v ${CLOISIM_RESOURCES_PATH}/models:/opt/resources/models/ \
    -v ${CLOISIM_RESOURCES_PATH}/worlds:/opt/resources/worlds/ \
    cloisim lg_seocho.world
```

#### Option B

Option B: just run with target world file name in 'worlds'

```shell
export CLOISIM_RESOURCES_PATH=/home/closim/SimulatorInstance/sample-resources/
./start.sh lg_seocho.world
```

refer to [samples_resource](https://github.com/lge-ros2/sample-resources) more details about resource

---------------------------

This docker image has been tested on __Ubuntu 18.04__.
