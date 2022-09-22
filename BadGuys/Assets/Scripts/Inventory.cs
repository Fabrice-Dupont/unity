using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
  public int appleGoldCount;
  public Text appleGoldCountText;
  public static Inventory instance ;

  private void Awake()
  {
    if(instance != null)
    {
      Debug.LogWarning("Il y a plus d'une instance de Inventory dans la scène");
      return;
  }    
    instance = this;
  }

  public void AddAppleGold(int count)
  {
    appleGoldCount+= count;
    appleGoldCountText.text = appleGoldCount.ToString();
  }
}
