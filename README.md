# AlaskaResourceMap
This Blazor app utilizes the following resources:
1) The USGS Alaska Resource Data File https://mrdata.usgs.gov/ardf/
2) MySQL for integration of data for map display
3) Blazor Leaflet https://github.com/Mehigh17/BlazorLeaflet
4) Open Street Map

Open AlaskaResourceData.csproj in your IDE for execution.

- Be sure to change the password for the designated MySQL server in `appsettings.json`.
- After importing the ardf.csv into the MySQL table, change the first letter of the column names so that it is capitalized.
