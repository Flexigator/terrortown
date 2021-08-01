using Sandbox;

partial class TerrortownPlayer : Player
{
	public override string Model { get; set; }

	public override void Respawn()
	{
		SetModel(GetModel());

		Controller = new WalkController();
		Animator = new StandardPlayerAnimator();
		Camera = new FirstPersonCamera();

		EnableAllCollisions = true;
		EnableDrawing = true;

		base.Respawn();
	}
}
