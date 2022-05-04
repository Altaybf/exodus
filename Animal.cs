namespace Exodus

public class Animal{
	
	private static int nbAnimals;
	
	private int health;
	private int hunger;
	
	private int speed;
	private MovementMode movementMode;
	
	private Color color;
	private int stealth;
	
	private int heatResistance;
	private int coldResistance;
	
	Alleles[]
	
	
	private Animal matingTarget = null;

	
	/**
	* ce rempli jusqu'à 60 avant que l'animal puisse passer à un autre chunck
	*/
	private int TravelDistance;
	
	private int[] coordinates;
	
	Random random; 
	
	public Animal() {
		health = 60 + random.Next(61);
		hunger = 60 + random.Next(61);
		
		speed = 60 + random.Next(61);
		
		r = random.Next();
		
		Switch(r)
		