namespace ENTREGABLE;
public interface IPokemon
{
    public void Add(PokemonDTO Pokemon);
    public void Delete(int id);
    public void Update(int id, PokemonDTO Pokemon);
    public PokemonDTO GetId(int id);
    List<PokemonDTO> All();
    public IEnumerable<PokemonDTO> Wh(String Tipo);
    public IEnumerable<PokemonDTO> Rango(int inicio, int final);

    }