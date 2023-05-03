namespace ENTREGABLE;

public class Pokemon : IPokemon{

private List<PokemonDTO> BD;

public Pokemon()
{
    this.BD = new List<PokemonDTO>();

}

public void Add(PokemonDTO Pokemon)
{
    this.BD.Add(Pokemon);
}

public void Delete(int id)
{
    this.BD.RemoveAll(Pokemon => Pokemon.Id == id);
}

public void Update(int id, PokemonDTO Pokemon)
{
    PokemonDTO pokemonUpdate=this.BD.Single((Pokemon => Pokemon.Id == id));
    pokemonUpdate.nombre= Pokemon.nombre;
    pokemonUpdate.tipo= Pokemon.tipo;
    pokemonUpdate.defensa= Pokemon.defensa;

}       


public PokemonDTO GetId(int id){
// PokemonDTO pokemonActualizar= this.BD.Single((pokemon => pokemon.Id == id));
    return this.BD.Single(pokemon => pokemon.Id == id);

}

//public PokemonDTO Getone(int id, PokemonDTO Pokemon){
  //  PokemonDTO pokemonGetone=this.BD.Single((Pokemon => Pokemon.Id == id));
    //return pokemonGetone;
//}
public List<PokemonDTO> All(){
return this.BD;
}

public IEnumerable<PokemonDTO> Wh(String Tipo){
return this.BD.Where(Pokemon => Pokemon.tipo == Tipo);
}

public IEnumerable<PokemonDTO> Rango(int inicio, int final){
return this.BD.Where(Pokemon => Pokemon.Id >= inicio && Pokemon.Id <= final );
}


}
