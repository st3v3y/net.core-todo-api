# NET.core todo API
Simple REST API in .NET core for todo items

## Open Endpoints

Open endpoints require no Authentication.

### Todo
* [All]() : `GET /api/v1/todo/`
* [Get]() : `GET /api/v1/todo/2`
* [Create]() : `POST /api/v1/todo/`
* [Update]() : `PUT /api/v1/todo/2`
* [Delete]() : `DELETE /api/v1/todo/2`


#### `GET` All
```
https://localhost:5001/api/v1/todo
```

```curl
curl --request GET \
  --url https://localhost:5001/api/v1/todo
```

#### `GET` Get
```
https://localhost:5001/api/v1/todo/2
```

```curl
curl --request GET \
  --url https://localhost:5001/api/v1/todo/2
```

#### `POST` Create New Todo
```
https://localhost:5001/api/v1/todo
```

##### Headers 
```
Content-Type	application/json
```

##### Body raw (application/json)
```
{
	text: "Programm nice apps!"
}
```

```curl
curl --request POST \
  --url https://localhost:5001/api/v1/todo \
  --header 'Content-Type: application/json' \
  --data '{
	text: "Programm nice apps!"
}'
```


#### `PUT` Update Todo
```
https://localhost:5001/api/v1/todo/2
```

##### Headers 
```
Content-Type	application/json
```

##### Body raw (application/json)
```
{
	checked:true
}
```

```curl
curl --request PUT \
  --url https://localhost:5001/api/v1/todo/2 \
  --header 'Content-Type: application/json' \
  --data '{
	checked:true
}'
```

#### `DELETE` Delete Todo
```
https://localhost:5001/api/v1/todo/4
```

```curl
curl --request DELETE \
  --url https://localhost:5001/api/v1/todo/4
```