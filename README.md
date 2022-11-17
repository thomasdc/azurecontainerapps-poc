[![Build and Deploy](https://github.com/thomasdc/azurecontainerapps-poc/actions/workflows/BuildDeploy.yml/badge.svg?branch=main)](https://github.com/thomasdc/azurecontainerapps-poc/actions/workflows/BuildDeploy.yml)

# What?

This is a sample repository of a Vue3 SPA embedded in an ASP.NET Core application hosted on [Azure Container Apps](https://acapoc-ca--bkn0lq3.nicedune-6b35d3ac.northeurope.azurecontainerapps.io/) using GitHub Actions.

# How to run locally

## Back-end
`\> dotnet run`

## Front-end

Restore npm packages

`\front-src> npm ci`

Run dev server

`\front-src> npm run dev`

# References
- https://github.com/MassTransit/Sample-ContainerApps
- https://www.youtube.com/watch?v=eKofKGAu3cQ
- https://learn.microsoft.com/en-us/azure/container-apps/