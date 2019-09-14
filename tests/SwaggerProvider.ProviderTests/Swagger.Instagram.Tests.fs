module Swagger.Instagram.Tests

open SwaggerProvider

let [<Literal>] Schema = __SOURCE_DIRECTORY__ + "/Schemas/v2/Instagram.json"
type Instagram = SwaggerClientProvider<Schema>

let insta = Instagram.Client()
