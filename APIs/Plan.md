
# Requirements : 
##  Small app with some code to consume APIs on Android Studio

## APIs 
- Insert Adress
- Return adress with range of coordinates and promotions urls

- Code : 
    - Algorithm to calculate postions more north, south, west and east adding more 100m (First will send coordinates of a cross, them is possible to make a circle or a rectangle with some math )
    
## Tables :
###  Tbl Customer 
```
    Id (autogenerated integer) | Adress  | Adress_Latitude (decimal(max)) | Adress_Longitude (decimal(max))
```
    
### Tbl promotions 
```
    Id (autogenerated integer) | customer_id (FK) | Promtion_image_link | Basic_Info (varchar_max)
```
    
## Notes : 
On google maps everthing is by 52.234202, 20.985243 meaning latitude longitue and not DMS (Degrees, Minutes, Seconds) so the conversion is not necessary. 
    
## Improvements to do : 
- use other type in DB : https://learn.microsoft.com/en-us/sql/t-sql/spatial-geography/spatial-types-geography?redirectedfrom=MSDN&view=sql-server-ver16
- Separate tables Customer | Coordinates ??
- Secret connection string
- Add payload of requests to Application Insights (using the SDK and specifying it in app settings)



