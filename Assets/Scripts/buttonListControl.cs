// created by Katoshia Grubb 4-28-21

// script used to store names of places and the number of options(buttons) that are needed as well as populate them into the game menu.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonListControl : MonoBehaviour
{
    public GameObject myButtonList;
    public string storyText;
    public List<GameObject> allButtons = new List<GameObject>();

    [SerializeField]
    public GameObject ButtonTemplate;

    [SerializeField]
    private GameObject TextTemplate;



    // Start Function by Katoshia Grubb

    // GameScene start for buttons shown. 1st runthough.
    private void Start()
    {
        PrintIntro();
        StartButtons();
    }
    
    // OnButtonClick by Katoshia Grubb (felt like this could've been done more smoothly.) Attempted Vectorcs but spaced on how to do it C#. Lists Possible?
    public void OnButtonClick(string theName, int optionCount)
    {
        DeleteDynamicButtons();

        if (theName == "Estate" || theName == "Go Outside")
        {
            EstateButton(optionCount);
        }
        else if (theName == "Lake")
        {
            LakeButton(optionCount);
        }
        else if (theName == "Back Woods" || theName == "Forest") 
        {
            BackWoodsButton(optionCount);
        }
        else if(theName == "Crypt")
        {
            CryptButton(optionCount);
        }
        else if (theName == "Inner Crypt")
        {
            InnerCryptButton(optionCount);
        }
        else if (theName == "Search Coffins")
        {
            SearchCoffinsButton(optionCount);
        }
        else if (theName == "Gardens")
        {
            GardensButton(optionCount);
        }
        else if (theName == "Main Entry" || theName == "Go Inside" )
        {
            MainEntryHallButton(optionCount);
            PrintMainEntry();
        }
        //else if(theName == "Go Outside")
        //{
        //    PrintGoOutside();
        //}
        else if (theName == "Explore Main Entry")
        {
            ExploreMainEntryButton(optionCount);
        }
        else if (theName == "Main Hall" || theName == "Main Hallway" || theName == "Upstairs")
        {
            MainHallwayButton(optionCount);
            PrintMainEntry();
        }
        else if (theName == "TrophyButton Room")
        {
            TrophyButton(optionCount);
        }
        else if (theName == "Explore Trophy Room")
        {
            ExploreTrophyButton(optionCount);
        }
        else if (theName == "Library")
        {
            LibraryButton(optionCount);
        }
        else if (theName == "Explore Library")
        {
            ExploreLibraryButton(optionCount);
        }
        else if (theName == "Read a book.")
        {
            ReadLibraryBookButton(optionCount);
        }
        else if (theName == "Bathroom")
        {
            BathroomButton(optionCount);
        }
        else if (theName == "Secret Library Room")
        {
            SecretLibraryRoomButton(optionCount);
        }
        else if (theName == "Explore Secret Room")
        {
            ExploreSecrectLibraryButton(optionCount);
        }
        else if (theName == "Sitting Room")
        {
            SittingRoomButton(optionCount);
        }
        else if (theName == "Dining Room")
        {
            DiningRoomButton(optionCount);
        }
        else if (theName == "Explore Dining Room")
        {
            ExploreDiningRoomButton(optionCount);
        }
        else if (theName == "Kitchen")
        {
            KitchenButton(optionCount);
        }
        else if (theName == "Explore Kitchen")
        {
            ExploreKitchenButton(optionCount);
        }
        else if (theName == "Take brownie")
        {
            TakeBrownieButton(optionCount);
        }
        else if (theName == "Pantry")
        {
            PantryButton(optionCount);
        }
        else if (theName == "Explore Pantry")
        {
            ExplorePantryButton(optionCount);
        }
        else if (theName == "Pull Lever")
        {
            PullLeverButton(optionCount);
        }
        else if (theName == "Small hallway")
        {
            SmallHallwayButton(optionCount);
        }
        else if (theName == "Pool Room")
        {
            PoolRoomButton(optionCount);
        }
        else if (theName == "Explore Pool Room")
        {
            ExplorePoolRoomButton(optionCount);
        }
        else if (theName == "Treasure Room")
        {
            TreasureRoomButton(optionCount);
        }
        else if (theName == "Explore Treasure Room")
        {
            ExploreTreasureRoomButton(optionCount);
        }
        else if (theName == "Second Floor")
        {
            SecondFloorButton(optionCount);
        }
        else if (theName == "First Hallway")
        {
            FirstHallwayButton(optionCount);
        }
        else if (theName == "Second Hallway")
        {
            SecondHallwayButton(optionCount);
        }
        else if (theName == "Explore the Hallway")
        {
            ExploreSecondHallwayButton(optionCount);
        }
        else if (theName == "Push the button")
        {
            PushBtnButton(optionCount);
        }
        else if (theName == "Master Bedroom")
        {
            MasterBedroomButton(optionCount);
        }
        else if (theName == "Explore Master Bedroom")
        {
            ExploreMasterBedroomButton(optionCount);
        }
        else if (theName == "Read the Book")
        {
            ReadBedroomBookButton(optionCount);
        }
        else if (theName == "Large closet")
        {
            MasterClosetButton(optionCount);
        }
        else if (theName == "Statue Room")
        {
            StatueRoomButton(optionCount);
        }
        else if (theName == "Guest Room")
        {
            GuestRoomButton(optionCount);
        }
        else if (theName == "Explore Guest Room")
        {
            ExploreGuestRoomButton(optionCount);
        }
        else if (theName == "Small Closet")
        {
            GuestClosetButton(optionCount);
        }
        else if (theName == "Explore the closet.")
        {
            ExploreGuestClosetButton(optionCount);
        }
        else if (theName == "Roayl Room")
        {
            RoyalRoomButton(optionCount);
        }
        else if (theName == "Servant's Hall")
        {
            ServantsHallButton(optionCount);
        }
        else if (theName == "Servant's Quarters")
        {
            ServantsQuartersButton(optionCount);
        }
        else if (theName == "Servant's Bathroom")
        {
            ServantsBathroomButton(optionCount);
        }
        else if (theName == "Mirror Room")
        {
            MirrorRoomButton(optionCount);
        }
        else if (theName == "Attic ")
        {
            AtticRoomButton(optionCount);
        }
        else if (theName == "Second Attic Room")
        {
            SecondAtticRoomButton(optionCount);
        }
        else if (theName == "Explore Second Room")
        {
            ExploreSecondAtticRoomButton(optionCount);
        }
        else if (theName == "Storage")
        {
            StorageButton(optionCount);
        }
    }

    // Dynamic Buttons by Katoshia Grubb

    // lake - 3 - swim, estate, back woods
    private void LakeButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);

                button.GetComponent<ButtonListButton>().SetText("Swim");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Estate");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);

            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Back Woods");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);

            }
        }
    }
    // estate - 3 - Lake, Go Inside/Main Entry Hall, Gardens/ 
    private void EstateButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Go Inside");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // swim ??
    // back woods - 3 - lake, gardens, crypt
    private void BackWoodsButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // crypt - 4 - Go Inside Crypt, Forest, Gardens, Estate
    private void CryptButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Inner Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Forest");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if(i==4)
            {
                button = Instantiate(ButtonTemplate) as GameObject; 
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Estate");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // inner crypt - 2 - Search Coffins, Leave Crypt
    private void InnerCryptButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Search Coffins");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Leave Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // Search Coffins - 2 - close lid, Leave crypt
    private void SearchCoffinsButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Close Lid");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Leave Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // gardens - 3 - lake, crypt, estate
    private void GardensButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Crypt");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if(i==3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Estate");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // main Entry Hall - Upstairs/Main Hall, Library, Explore Main Entry
    private void MainEntryHallButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Go Outside");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hallway");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 4)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Entry");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // Explore main entry - 2 - Upstairs/Main Hall, Library
    private void ExploreMainEntryButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Upstairs");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Upstairs/Main Hall - 4 - Second Floor, Sitting Room, Bathroom, Trophy Room
    private void MainHallwayButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Second Floor");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Sitting Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
            if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Bathroom");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 4)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Trophy Room - 3 - Main Hall, Library, Explore Trophy Room
    private void TrophyButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // Explore Trophy Room - 2 - Main Hall, library
    private void ExploreTrophyButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // library - 3 - trophy room, main hall, explore library
    private void LibraryButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Explore Library - 3 - trophy room, main hall, read a book
    private void ExploreLibraryButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Read a Book");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // Read a Book - 3 - Trophy room, Main Hall, Secret Room(library)
    private void ReadLibraryBookButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Trophy Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Secret Library Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 2));
                allButtons.Add(button);
            }
        }
    }
    // Bathroom - 1 - Main Hall
    private void BathroomButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // Secret Room - 2 - library, Explore Secret room
    private void SecretLibraryRoomButton(int optionCount)
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Explore Secret Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 1));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // explore secret room - 1 - library
    private void ExploreSecrectLibraryButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Library");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }
    // sitting room - 2 - main hall, dining room
    private void SittingRoomButton(int optionCount) 
    {
        for (int i = 1; i <= optionCount; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Main Hall");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Dining Room");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 4));
                allButtons.Add(button);
            }
        }
    }
    // dining room - 4 - sitting room, kitchen, pantry, Explore Dining Room
    private void DiningRoomButton(int optionCount) { }
    // Explore Dining room - 3 - sitting room, kitchen, pantry
    private void ExploreDiningRoomButton(int optionCount) { }
    // kitchen - small hallway, dining room, explore kitchen
    private void KitchenButton(int optionCount) { }
    // explore kitchen - 3 - small hallway, dining room, take a brownie
    private void ExploreKitchenButton(int optionCount) { }
    // take brownie - 2 - small hallway, dining room
    private void TakeBrownieButton(int optionCount) { }
    // pantry - 2 - dining room, explore pantry
    private void PantryButton(int optionCount) { }
    // explore pantry - dining room, pull lever
    private void ExplorePantryButton(int optionCount) { }
    // pubb lever - 2 - dining room, pool room
    private void PullLeverButton(int optionCount) { }
    // small hallway - 2 - servant's hall, kitchen
    private void SmallHallwayButton(int optionCount) { }
    // pool room - 2 - pantry, explore pool room
    private void PoolRoomButton(int optionCount) { }
    // explore pool room - 1 - pantry
    private void ExplorePoolRoomButton(int optionCount) { }
    // treasure room - 2 - climb ladder(guest room), explore treasure room
    private void TreasureRoomButton(int optionCount) { }
    // explore treasure room - 1 -climb ladder(guest room)
    private void ExploreTreasureRoomButton(int optionCount) { }
    // 2nd floor - 4 - back downstairs, master bedroom, first hallway, 2nd hallway
    private void SecondFloorButton(int optionCount) { }
    // 1st hallwall - 3 - guest room, 2nd floor hallway, 2nd hallway
    private void FirstHallwayButton(int optionCount) { }
    // 2nd hallway - 3 - 1st hallway, upstairs(attic room), Explore hallway
    private void SecondHallwayButton(int optionCount) { }
    // Explore 2nd hallway - 3 - 1st hall, upstairs(attic room), push button
    private void ExploreSecondHallwayButton(int optionCount) { }
    // push button - 3 - 1st hallway, upstairs(attic room), mirror room
    private void PushBtnButton(int optionCount) { }
    // master bedroom - 3 - 2nd floor hallway, walk-in closet, Explore master bedroom
    private void MasterBedroomButton(int optionCount) { }
    // explore master bedroom - 3 - 2nd floor hallway, walk-in closet, read a book
    private void ExploreMasterBedroomButton(int optionCount) { }
    // read a book(master Bedroom) - 3 - walk-in closet, 2nd floor hallway, statue room
    private void ReadBedroomBookButton(int optionCount) { }
    // walk-in closet - 1 - master bedroom
    private void MasterClosetButton (int optionCount) { }
    // statue room - 1 - master bedroom
    private void StatueRoomButton(int optionCount) { }
    // guest room - 3 - 1st hallway, walk-in closet(guest room), explore guest room
    private void GuestRoomButton(int optionCount) { }
    // explore guest room - 3 - 1st hallway, walk-in closet(guest room), climb down ladder(treasure room)
    private void ExploreGuestRoomButton(int optionCount) { }
    // guest walk-in closet - 2 - guest bedroom, explore walk-in closet(guest room)
    private void GuestClosetButton(int optionCount) { }
    // explore guest walk-in closet - 2 - guest bedroom, royal room
    private void ExploreGuestClosetButton(int optionCount) { }
    // royal room - 1 -walk-in closet(guest room)
    private void RoyalRoomButton(int optionCount) { }
    // servant's hall (small hallway) - 3 - downstairs to small hallway, servant quarters, servants bathroom
    private void ServantsHallButton(int optionCount) { }
    // servant quarters - 1 - return to servant's hall
    private void ServantsQuartersButton(int optionCount) { }
    // servant's bathroom - 1 - return to servant's hall
    private void ServantsBathroomButton(int optionCount) { }
    // mirror room - 1 - 2nd hallway
    private void MirrorRoomButton(int optionCount) { }
    // attic room - 2 - 2nd hallway, secondary attic room
    private void AtticRoomButton(int optionCount) { }
    // secondary attic room - 3 - attic space, more storage, explore secondary attic room
    private void SecondAtticRoomButton(int optionCount) { }
    // explore secondary attic room - 2 - attic space, more storage
    private void ExploreSecondAtticRoomButton(int optionCount) { }
    // more storage 1 - return to secondary attic space
    private void StorageButton(int optionCount) { }

    // Start buttons for GameScene by Katoshia Grubb
    private void StartButtons()
    {
        for (int i = 1; i <= 3; i++)
        {
            GameObject button;
            if (i == 1)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Lake");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 2)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Go Inside");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
            else if (i == 3)
            {
                button = Instantiate(ButtonTemplate) as GameObject;
                button.SetActive(true);
                button.GetComponent<ButtonListButton>().SetText("Gardens");
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                string tempName = button.GetComponentInChildren<Text>().text;
                button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(tempName, 3));
                allButtons.Add(button);
            }
        }
    }

    // Delete Dynamic Elements by Katoshia Grubb
    public void DeleteDynamicButtons()
    {
        foreach (GameObject button in allButtons)
        {
            Destroy(button);
        }
        allButtons.Clear();
    }
    public void DeleteDynamicText()
    {
        Destroy(GameObject.Find("StoryText(Clone)"));
    }


    // Print Functions by Youlanda Daffron
    private void PrintIntro()
    {
        GameObject textStory;
        textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("Lord Shuran Dunkeld, your grandfather, is known for being a warrior, a leader and sometimes an adventurer in the service of the king. Recently, you and your family have moved into the Dunkeld estate due to rumors about your grandfather disappearing, and even being dead. While your parents handle the responsibilities of the estate, you have been left to explore as you wish. You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);
    }
    private void PrintMainEntry()
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You enter the main entry hall. Pillars, suits of armor and benches line the walls of this room.There is also a large chandelier that hangs from the ceiling and a decorative red and gold rug that covers most of the polished stone floor.There are stairs that lead up to a hallway and a door that goes to the library.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);
    }
    private void PrintGoOutside()
    {
        DeleteDynamicText();
        GameObject textStory = Instantiate(TextTemplate) as GameObject;
        textStory.SetActive(true);
        textStory.GetComponent<ButtonListButton>().SetText("You currently stand at the bottum of the stairs leading up to the front doors of the estate. You can smell the sweet scent of flowers from the nearby gardens and can see the waters of a rather large lake in the near distance, on the other side of some fields.");
        textStory.transform.SetParent(TextTemplate.transform.parent, false);
    }
}