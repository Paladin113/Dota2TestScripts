using System.Collections.Generic;
using UnityEngine;

public class ButtonThanks : MonoBehaviour
{
    private readonly List<string> audioList = new List<string>();

    public void playSound()
    {
        gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(audioList[Random.Range(0, audioList.Count)]);
        gameObject.GetComponent<AudioSource>().Play();
    }

    private void Start()
    {
        audioList.Add("Sounds/Heroes/Abad_ally_06_ru");
        audioList.Add("Sounds/Heroes/Abys_ally_01_ru");
        audioList.Add("Sounds/Heroes/Arcwar_rival_07_ru");
        audioList.Add("Sounds/Heroes/Arcwar_rival_14_ru");
        audioList.Add("Sounds/Heroes/Bristle_attack_22_ru");
        audioList.Add("Sounds/Heroes/Cent_ally_19_ru");
        audioList.Add("Sounds/Heroes/Cm_rival_19_ru");
        audioList.Add("Sounds/Heroes/Dazz_ability_shalgrave_01_ru");
        audioList.Add("Sounds/Heroes/Doom_ally_02_ru");
        audioList.Add("Sounds/Heroes/Drag_rival_10_ru");  
        audioList.Add("Sounds/Heroes/Earthspi_bottle_01_ru");
        audioList.Add("Sounds/Heroes/Embr_ally_12_ru");    
        audioList.Add("Sounds/Heroes/Fate's_Edict_cast");
        audioList.Add("Sounds/Heroes/Gyro_ally_05_ru");      
        audioList.Add("Sounds/Heroes/Invo_ability_icewall_03_ru");
        audioList.Add("Sounds/Heroes/Keep_ally_11_ru");
        audioList.Add("Sounds/Heroes/Kunk_ally_02_ru");
        audioList.Add("Sounds/Heroes/Legcom_rare_02_ru");      
        audioList.Add("Sounds/Heroes/Legcom_rival_06_ru");
        audioList.Add("Sounds/Heroes/Luna_ally_01_ru");
        audioList.Add("Sounds/Heroes/Lycan_illus_02_ru");
        audioList.Add("Sounds/Heroes/Mir_rare_01_ru");        
        audioList.Add("Sounds/Heroes/Nyx_ally_05_ru");
        audioList.Add("Sounds/Heroes/Omni_purch_02_ru");     
        audioList.Add("Sounds/Heroes/Omni_rare_01_ru");
        audioList.Add("Sounds/Heroes/Pud_death_06_ru");
        audioList.Add("Sounds/Heroes/Pud_respawn_01_ru");
        audioList.Add("Sounds/Heroes/Pud_rival_06_ru");     
        audioList.Add("Sounds/Heroes/Ratt_respawn_18_ru");
        audioList.Add("Sounds/Heroes/Raz_rival_15_ru");     
        audioList.Add("Sounds/Heroes/RuneBounty");
        audioList.Add("Sounds/Heroes/Shad_killspecial_01_ru");
        audioList.Add("Sounds/Heroes/Slark_ally_03_ru");
        audioList.Add("Sounds/Heroes/Snip_kill_arrow_03_ru");      
        audioList.Add("Sounds/Heroes/Spir_rare_05_ru");
        audioList.Add("Sounds/Heroes/Stormspirit_rival_06_ru");
        audioList.Add("Sounds/Heroes/Sven_rivals_general_07_ru");        
        audioList.Add("Sounds/Heroes/Templar_Assassin_projectile_launch2");
        audioList.Add("Sounds/Heroes/Wdoc_immort_02_ru");
        audioList.Add("Sounds/Heroes/Weapons_hero_snapfire_attack");
        audioList.Add("Sounds/Heroes/Weaver_projectile_launch1");
        audioList.Add("Sounds/Heroes/Winwyv_respawn_03_ru");
        audioList.Add("Sounds/Heroes/Wind_rivaltrax_04_ru");   
        audioList.Add("Sounds/Heroes/Wraith_rival_24_ru");
        audioList.Add("Sounds/Heroes/Pud_respawn_01_ru");
    }
}
