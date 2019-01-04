
class PlayerStatManager{
	
	//needed to 'link' the animator
	enum PlayerState{ idle, running, attack, attack_running, hit, dead, poisoned, bloody, crippled, downgrab, cloaked }
	
	public const int MAX_LEVEL = 180;

	private float currentExperience;
	private float newLevelExp;
	private int currentLevel;
	private int newLevels;

	private float topHealth;
	private float topStamina;
	private float topHunger;
	private float topThirst;
	private float topTemperature;

	private float currentHealth;
	private float currentStamina;
	private float currentHunger;
	private float currentThirst;
	private float currentTemperature;

	private float baseMeleeDamage;
	private float meleeDamageMultiplier;
	private float baseSpeed;
	private float speedMultiplier;

	
	private PlayerState     currentState;
	private StatsEffects[]  activeEffects;

//TO DO 
	public PlayerState getCurrentState(){return currentState;}
	
	public setState(PlayerState ps){currentState=ps;}
	

	public addStatsEffects(){}




}