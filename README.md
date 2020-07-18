
[![Build status](https://ci.appveyor.com/api/projects/status/muh68y3r9kgv2cko?svg=true)](https://ci.appveyor.com/project/RichardNewman/astarcli)

## Description

A simple app to calculate basic building metrics. 

See inputs below

## Future development

* Add CLI for individual inputs rather than json / array / file options 
* Replace console logging and exception handling
* Use rule engine for building calculations and use base class
* Handle invalid input/serialization exceptions
* Add AOP logging around rule engine
* Async calculation of results
* Convert to API

## Install Dependencies

If your IDE doesn't automatically install your .NET NuGet Dependencies, you can manually install them with:

    $ dotnet restore
   
## Run

After building the application browser to the compiled directory and run the console app

Follow the CLI commands, e.g.

    $ ExampleCLI.exe --help

    $ ExampleCLI.exe -i "[{\"width\":100,\"length\":500,\"site_config\":{\"num_storeys\":0,\"site_coverage\":90,\"development_type\":\"subdivision\",\"avg_lot_size\":300}},{\"width\":50,\"length\":100,\"site_config\":{\"num_storeys\":3,\"site_coverage\":70,\"development_type\":\"apartment\",\"avg_apt_area\":74}},{\"width\":250,\"length\":700,\"site_config\":{\"num_storeys\":5,\"site_coverage\":70,\"development_type\":\"mixed_use\",\"avg_apt_area\":74,\"commerical_mix\":20,\"retail_mix\":70,\"residential_mix\":10}},{\"width\":250,\"length\":700,\"site_config\":{\"num_storeys\":20,\"site_coverage\":70,\"development_type\":\"commercial\",\"commerical_mix\":20,\"retail_mix\":70}},{\"width\":50,\"length\":100,\"site_config\":{\"num_storeys\":3,\"site_coverage\":70,\"development_type\":\"apartment\"}},{\"width\":20,\"length\":30,\"site_config\":{\"num_storeys\":2,\"site_coverage\":70,\"development_type\":\"apartment\",\"avg_apt_area\":90}},{\"width\":10,\"length\":50,\"site_config\":{\"num_storeys\":0,\"site_coverage\":90,\"development_type\":\"subdivision\",\"avg_lot_size\":450}},{\"width\":10,\"length\":50,\"site_config\":{\"num_storeys\":0,\"site_coverage\":90,\"development_type\":\"subdivision\",\"avg_lot_size\":500}}]"


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

## Test

    $ dotnet test

See EndToEndTests.cs for sample input    