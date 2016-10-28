What is Docker?
---------------

> Docker provides a way to run applications securely isolated in a container, packaged with all its dependencies and libraries. Because your application can always be run with the environment it expects right in the build image, testing and deployment is simpler than ever, as your build will be fully portable and ready to run as designed in any environment. And because containers are lightweight and run without the extra load of a hypervisor, you can run many applications that all rely on different libraries and environments on a single kernel, each one never interfering with the other. This allows you to get more out of your hardware by shifting the “unit of scale” for your application from a virtual or physical machine, to a container instance.

> [More on the Official Docker Documentation.](https://docs.docker.com/)

Docker containers wrap up a piece of software in a complete filesystem that contains everything it needs to run: code, runtime, system tools, system libraries - anything you can install on a server. This guarantees that it will always run the same, regardless of the environment it is running in.

![](media/vm-container.png)

Each **virtual machine** includes the application, the necessary binaries and libraries and an entire guest operating system - all of which may be tens of GBs in size.

By contrast, **containers** include the application and all of its dependencies, but share the kernel with other containers. They run as an isolated process in userspace on the host operating system. They're also not tied to any specific infrastructure - Docker containers run on any computer, on any infrastructure and in **any cloud**.


Why use Docker to build applications?
-------------------------------------
There are several good reasons to consider Docker:

- **Consistent Environments**. By packaging up the application with its configs and dependencies together and shipping as a container, the application will always work as designed locally, on another machine, in test or production. No more worries about having to install the same configs into a different environment.
- **Small Footprint**. As explained above, sharing a kernel and filesystem layering makes for very small containers.
- **Continuous Delivery**. Your Continous Integration and Continous Delivery solution - for instance [Visual Studio Team Services](https://www.visualstudio.com/team-services/), [Team Foundation Server](https://www.visualstudio.com/en-us/products/tfs-overview-vs.aspx) or [Jenkins](http://jenkins-ci.org/) - can be easily configured to use Docker containers to automatically build, deploy and test apps. So you can get a fully automated dev / test / production pipeline.
- **Work together**. With [Docker Hub](https://hub.docker.com/) you can create and share your Docker images with other developers. Or you can stand up your private hub for your company to use.

Get started with Docker
-----------------------

There are a lot of resource available to start learning Docker. Here are a few of them:

- [The Official Docker Documentation](https://docs.docker.com/) - as always, the first place to go when learning a new technology is the official documentation
- [Great Pluralsight collection of courses by Nigel Poulton](https://www.pluralsight.com/paths/docker) - most often, the second best place to go is Pluralsight

What is Docker Hub?
-------------------
>[**Docker Hub**](https://hub.docker.com/) is a cloud-based registry service which allows you to link to code repositories, build your images and test them, stores manually pushed images, and links to [Docker Cloud](https://cloud.docker.com/) so you can deploy images to your hosts. It provides a centralized resource for container image discovery, distribution and change management, user and team collaboration, and workflow automation throughout the development pipeline.

Every container you run in based on an image. Docker Hub is one of the central places from where you can *pull* images that are *pushed* by organizations or individual developers.

You can find many official images like Ubuntu, Redis, NGINX or Mongo, images that are maintained by their respective organization and that you can use as images for your containers.

![](media/docker-hub.png)

Docker Cloud?
-------------

> Docker Cloud is a hosted service that provides a Registry with build and testing facilities for Dockerized application images, tools to help you set up and manage your host infrastructure, and deployment features to help you automate deploying your images to your infrastructure.

> Docker Cloud uses Docker Hub as an online registry service. This allows you to publish Dockerized images on the internet either publicly or privately. Along with the ability to store pre-built images, Docker Cloud can link to your source code repositories and manage building and testing your images before pushing the images.

You can use VMs from Amazon Web Services, DigitalOcean or Microsoft Azure.
