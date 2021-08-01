using Sandbox;

public partial class Terrortown : Sandbox.Game
{
	public Terrortown()
	{
		
	}

	public override void ClientJoined(Client client)
	{
		base.ClientJoined(client);

		TerrortownPlayer player = new TerrortownPlayer();
		client.Pawn = player;

		player.Respawn();
	}
}
