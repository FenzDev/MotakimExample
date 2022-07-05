namespace Example;

class Core : GameManager
{
    public Core()
    {
        // TODO : Initialize stuff before the game runs.
        
        // Add scene to the game.
        Game.Scenes.Add(new InitScene());
    }
}