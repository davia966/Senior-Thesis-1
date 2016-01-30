using UnityEngine;
using System.Collections;

public class TreeSpawner : MonoBehaviour
{
	
	//Amount of Trees to spawn
	public int treesToSpawn = 500;
	
	//Tree array
	public GameObject[] treeTypes1 = new GameObject[0];
	public GameObject[] treeTypes2 = new GameObject[0];
	public GameObject[] treeTypes3 = new GameObject[0];
	public GameObject[] treeTypes4 = new GameObject[0];
	
	//Tree height min/max
	public int treeMaxHeight;
	public int treeMinHeight;
	
	//randSpawn Vector3, holds the spawn point
	private Vector3 randSpawn;
	
	// Use this for initialization
	void Start ()
		
	{
		SpawnTrees();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void SpawnTrees()
	{
		//While new variable i = 0 is < treesToSpawn
		for (int i=0; i < treesToSpawn;)
		{
			//Create a new vector3 to hold the spawn location
			Vector3 terrainPoint = new Vector3 (0,0,0);
			
			//Find the overall size of the terrain
			terrainPoint = Terrain.activeTerrain.terrainData.size;
			
			//Set randSpawn to use a random point from terrainPoint
			randSpawn = new Vector3 (Random.Range (0,terrainPoint.x), 0, Random.Range (0,terrainPoint.z));
			
			//Find terrain height at randSpawn
			float spawnHeight = Terrain.activeTerrain.SampleHeight(randSpawn);
			
			//Adjust spawnHeight to be on terrain
			randSpawn.y = spawnHeight;
			
			//Only spawn and increment the for loop if the height is above/below the min/max heights
			if (spawnHeight < treeMaxHeight && spawnHeight > treeMinHeight) //&& spawnSlope <= spawnMaxSlope)
			{
				//Function to select array based on region
				selectArrayFromRegion();
				
				//Increment spawnTrees
				i++;
				
			}
			
		}
	}
	
	void selectArrayFromRegion()
	{
		//Check for collision with 'region' at randSpawn
		Collider[] regionCheck = Physics.OverlapSphere(randSpawn, 5);
		
		//For each collision, perform the following checks
		foreach (Collider regionHit in regionCheck)
			
			if (regionHit.tag == "TreeSpawnType1")
		{
			SpawnTreeType1();
		}
		
		else if (regionHit.tag == "TreeSpawnType2")
		{
			SpawnTreeType2();
		}
		
		else if (regionHit.tag == "TreeSpawnType3")
		{
			SpawnTreeType3();
		}
		
		else if (regionHit.tag == "TreeSpawnType4")
		{
			SpawnTreeType4();
		}
		
	}
	
	void SpawnTreeType1()
	{
		//Select random tree from treeTypes array
		GameObject treeToSpawn = treeTypes1[Random.Range(0, treeTypes1.Length)];  
		
		//Spawn
		Instantiate (treeToSpawn, randSpawn,  Quaternion.identity);
		
	}
	
	void SpawnTreeType2()
	{
		//Select random tree from treeTypes array
		GameObject treeToSpawn = treeTypes2[Random.Range(0, treeTypes2.Length)];  
		
		//Spawn
		Instantiate (treeToSpawn, randSpawn,  Quaternion.identity);
		
	}
	
	void SpawnTreeType3()
	{
		//Select random tree from treeTypes array
		GameObject treeToSpawn = treeTypes3[Random.Range(0, treeTypes3.Length)];  
		
		//Spawn
		Instantiate (treeToSpawn, randSpawn,  Quaternion.identity);
		
	}
	
	void SpawnTreeType4()
	{
		//Select random tree from treeTypes array
		GameObject treeToSpawn = treeTypes4[Random.Range(0, treeTypes4.Length)];  
		
		//Spawn
		Instantiate (treeToSpawn, randSpawn,  Quaternion.identity);
		
	}
	
}
