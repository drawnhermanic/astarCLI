
[![Build status](https://ci.appveyor.com/api/projects/status/ehs1oynofatousqq?svg=true)](https://ci.appveyor.com/project/RichardNewman/ExampleCLI)

## Description

A simple app to calculate basic building metrics. 

See inputs below

## Future development

* Add CLI for individual inputs rather than json / array / file options 
* Replace console logging
* Additional validation of inputs
* Async calculation of results
* Convert to API 

## Install Dependencies

If your IDE doesn't automatically install your .NET NuGet Dependencies, you can manually install them with:

    $ dotnet restore
   
## Run

Execute the application by running the following from the ExampleCLI project directory

    $ dotnet run

Follow the CLI commands

* Sample input: 

```
[
  {
    "width": 100,
    "length": 500,
    "site_config": {
      "num_storeys": 0,
      "site_coverage": 90,
      "development_type": "subdivision",
      "avg_lot_size": 300
    }
  },
  {
    "width": 50,
    "length": 100,
    "site_config": {
      "num_storeys": 3,
      "site_coverage": 70,
      "development_type": "apartment",
      "avg_apt_area": 74
    }
  },
  {
    "width": 250,
    "length": 700,
    "site_config": {
      "num_storeys": 5,
      "site_coverage": 70,
      "development_type": "mixed_use",
      "avg_apt_area": 74,
      "commerical_mix": 20,
      "retail_mix": 70,
      "residential_mix": 10
    }
  },
  {
    "width": 250,
    "length": 700,
    "site_config": {
      "num_storeys": 20,
      "site_coverage": 70,
      "development_type": "commercial",
      "commerical_mix": 20,
      "retail_mix": 70
    }
  },
  {
    "width": 50,
    "length": 100,
    "site_config": {
      "num_storeys": 3,
      "site_coverage": 70,
      "development_type": "apartment"
    }
  },
  {
    "width": 20,
    "length": 30,
    "site_config": {
      "num_storeys": 2,
      "site_coverage": 70,
      "development_type": "apartment",
      "avg_apt_area": 90
    }
  },
  {
    "width": 10,
    "length": 50,
    "site_config": {
      "num_storeys": 0,
      "site_coverage": 90,
      "development_type": "subdivision",
      "avg_lot_size": 450
    }
  },
  {
    "width": 10,
    "length": 50,
    "site_config": {
      "num_storeys": 0,
      "site_coverage": 90,
      "development_type": "subdivision",
      "avg_lot_size": 500
    }
  }
]
```
## Build

Run the Nuke build project. Can be executed as from the powershell script

    $ .\build.ps1 --target build --configuration release 

## Test

    $ dotnet test