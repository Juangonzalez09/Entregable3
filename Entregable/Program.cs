using ENTREGABLE;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Pokemon Pokemon= new Pokemon();


app.MapPost("/api/v1/pokemon",(PokemonDTO pokemon) => {
    Pokemon.Add(pokemon);
});


app.MapGet("/api/v1/pokemon", () => {
    return Results.Ok(Pokemon.All());
});
//app.MapGet("/api/v1/pokemonsg1/{id}", (int  id, PokemonDTO pokemon) => {
  //  return Results.Ok(Pokemon.Getone(id,pokemon));
//});

app.MapPut("/api/v1/pokemon/{id}", (int  id, PokemonDTO pokemon) => {
   Pokemon.Update(id, pokemon);
    
});

  

  app.MapGet("/api/v1/pokemon/solo/{id}", (int id) => {
   return Results.Ok(Pokemon.GetId(id));
  });



  
  app.MapGet("/api/v1/pokemon/tipo/{tipo}", (string Tipo) => {
     return Results.Ok(Pokemon.Wh(Tipo));

  });


  app.MapPost("/api/v1/pokemon/Varios",(PokemonDTO[] pokemonDTO) => {
    for(int i=0; i<= pokemonDTO.Length-1; i++){
            Pokemon.Add(pokemonDTO[i]);
    }
    
});

app.MapDelete("/api/v1/pokemon/eliminar/{id}", (int id) => {
   Pokemon.Delete(id);

});

app.MapGet("/api/v1/pokemon/{inicio}/{final}",(int inicio, int final) => {
    return Results.Ok(Pokemon.Rango(inicio, final));

});

 app.Run();   

