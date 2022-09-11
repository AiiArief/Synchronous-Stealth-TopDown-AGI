using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LocalizationLanguage
{
    Game, English, Indonesia
}

public class LocalizationString
{
    public string[] translatedStrings;

    public LocalizationString(string english, string indonesia, string game = "")
    {
        translatedStrings = new string[] { game, english, indonesia };
    }
}

public class LocalizationManager : MonoBehaviour
{
    public static string Translate(LocalizationString localizationString)
    {
        int languageId = PlayerPrefs.GetInt(ProfileManager.PLAYERPREFS_LANGUAGEID, 1);
        return localizationString.translatedStrings[languageId];
    }

    #region Tutorial
    public static readonly LocalizationString TUTORIAL_MOVE = new LocalizationString("Press to move", "Tekan untuk bergerak");
    public static readonly LocalizationString TUTORIAL_INTERACT = new LocalizationString("Hit any object to interact", "Tabrak objek apapun untuk berinteraksi");
    public static readonly LocalizationString TUTORIAL_RUN = new LocalizationString("Hold + move to run", "Tahan + gerak untuk lari");
    public static readonly LocalizationString TUTORIAL_SKIP = new LocalizationString("Rapidly tap to skip turn", "Tekan berkali-kali untuk lewati giliran");
    public static readonly LocalizationString TUTORIAL_NEXT = new LocalizationString("Next", "Lanjut");
    public static readonly LocalizationString TUTORIAL_SELECT = new LocalizationString("Select", "Pilih");
    public static readonly LocalizationString TUTORIAL_CHECKPOINT = new LocalizationString("Checkpoint!", "Checkpoint!");
    public static readonly LocalizationString TUTORIAL_HUBWORLD = new LocalizationString("Hub World", "Hub World");
    public static readonly LocalizationString TUTORIAL_UBIVISION = new LocalizationString("Ubivision 6th Floor", "Ubivision Lantai 6");
    public static readonly LocalizationString TUTORIAL_UBIVISION_TOPFLOOR = new LocalizationString("Ubivision Top Floor", "Ubivision Top Floor");
    #endregion

    #region Character
    public static readonly LocalizationString CHARACTER_MYSTERIOUSVOICES = new LocalizationString(
        "???",
        "???",
        "3f 3f 3f"
    );

    public static readonly LocalizationString CHARACTER_THEDEVELOPER = new LocalizationString(
        "The Developer",
        "The Developer"
    );

    public static readonly LocalizationString CHARACTER_3DHEADPHONESPHEREROBOT_GUARD = new LocalizationString(
        "(3D Headphone Sphere Robot) Guard",
        "(3D Headphone Sphere Robot) Satpam"
    );

    public static readonly LocalizationString CHARACTER_DEVELOPERNOTE = new LocalizationString(
        "Developer Note",
        "Pesan Developer"
    );

    public static readonly LocalizationString CHARACTER_DEVELOPERLOGDIARY = new LocalizationString(
        "Developer Log Diary",
        "Developer Log Diary"
    );

    public static readonly LocalizationString CHARACTER_2D1BIT_DOOR = new LocalizationString(
        "(2D 1 Bit) Door",
        "(2D 1 Bit) Pintu"
    );

    public static readonly LocalizationString CHARACTER_2D1BIT_SWITCH = new LocalizationString(
        "(2D 1 Bit) Switch",
        "(2D 1 Bit) Saklar"
    );

    public static readonly LocalizationString CHARACTER_2D1BIT_DOORPASSWORD = new LocalizationString(
        "(2D 1 Bit) Door with Password",
        "(2D 1 Bit) Pintu dengan Password"
    );

    public static readonly LocalizationString CHARACTER_CRACKOFTIME = new LocalizationString(
        "Crack of Time",
        "Pecahan Waktu"
    );

    public static readonly LocalizationString CHARACTER_RGBGAMINGDOOR = new LocalizationString(
        "(2D 1 Bit) RGB Gaming Door",
        "(2D 1 Bit) Pintu Gaming RGB"
    );

    public static readonly LocalizationString CHARACTER_ELEFATAA = new LocalizationString(
        "(2D 1 Bit) Elefataa",
        "(2D 1 Bit) Elefataa"
    );

    public static readonly LocalizationString CHARACTER_BOBAKOTAK = new LocalizationString(
        "(2D Humanoid) Boba Kotak",
        "(2D Humanoid) Boba Kotak"
    );

    public static readonly LocalizationString CHARACTER_BOARDDIRECTORS = new LocalizationString(
        "Board Directors",
        "Dewan Direksi"
    );

    #endregion

    #region Generic Dialogues
    public static readonly LocalizationString PAUSE_CHOICES_1 = new LocalizationString(
        "... (Resume)",
        "... (Lanjutkan main)"
    );

    public static readonly LocalizationString PAUSE_CHOICES_2 = new LocalizationString(
        "I want to time leap! (Restart from last checkpoint)",
        "Mau time leap! (Ulang dari checkpoint terakhir)"
    );

    public static readonly LocalizationString PAUSE_CHOICES_3 = new LocalizationString(
        "I don't want to work anymore. (Quit)",
        "Udahan kerjanya ah. (Keluar dari game)"
    );

    public static readonly LocalizationString CAPTURED = new LocalizationString(
        "STOP RIGHT THERE! ALERT! ALERT!",
        "WOY, SIAPA LU! ALERT! ALERT!"
    );

    public static readonly LocalizationString CAPTURED_CHOICES_1 = new LocalizationString(
        "It's time to time leap! (Restart from last checkpoint)",
        "Saatnya time leap! (Ulang dari checkpoint terakhir)"
    );

    public static readonly LocalizationString CAPTURED_CHOICES_2 = new LocalizationString(
        "I'm out. (Quit)",
        "Au ah. (Keluar)"
    );

    public static readonly LocalizationString QUIT = new LocalizationString(
        "W-WAIT A MINUTE!",
        "EHHH BENTAR BENTAR!"
    );

    public static readonly LocalizationString THE_ANSWER_IS = new LocalizationString(
        "The answer is ",
        "Jawabannya adalah "
    );
    #endregion

    #region Void World Dialogues

    #region End Game
    public static readonly LocalizationString VW_ONLOAD_ENDGAME_0 = new LocalizationString(
        "Welcome back, Agent Violet.",
        "Yo, Agent Violet. Selamat datang kembali."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_1 = new LocalizationString(
        "I see that you have found evidence that Ubivision violates their workers' rights, especially women workers.",
        "Gua liat lu udah menemukan bukti mengenai pelanggaran hak-hak pekerja terutama pekerja perempuan di perusahaan Ubivision."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_14 = new LocalizationString(
        "I'll give this evidence to journalist later.",
        "Gua akan memberikan bukti ini ke jurnalis nanti."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_15 = new LocalizationString(
        "I hope Boba Kotak gets the punishment he deserves, but unfortunately, it's up to the NPCs what to do with this information.",
        "Gua ngarepnya sih Boba Kotak diberi hukuman setimpal, tapi terserah NPC sih mau diapain informasi ini."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_16 = new LocalizationString(
        "Anyway, congratulation for finding this evidence.",
        "Anyway, congrats berhasil menemukan barang bukti ini."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_17 = new LocalizationString(
        "Now how about devlog diary, did you find everything?",
        "Nah gimana dengan devlog diary, apakah lu menemukan semuanya?"
    );

    #region Check Devlog Diary
    public static readonly LocalizationString VW_ONLOAD_ENDGAME_17_COMPLETE_0 = new LocalizationString(
        "Wow! You found everything!",
        "Wow! Lu menemukan semuanya!"
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_17_COMPLETE_1 = new LocalizationString(
        "Well I promised that if you found all of it I will give you a prize...",
        "Gua kan janji ya kalau lu nemu semuanya bakalan gua kasih hadiah..."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_17_COMPLETE_2 = new LocalizationString(
        "And the prize is...",
        "Hadiahnya adalah..."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_17_COMPLETE_3 = new LocalizationString(
        "CONGRATULATIONS!",
        "SELAMAT!!!"
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_17_UNCOMPLETE_0 = new LocalizationString(
        "Oh no... you didn't find all of it...",
        "Yah, lu ga nemu semua diarinya."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_17_UNCOMPLETE_1 = new LocalizationString(
        "W-well... it's okay... I guess...",
        "Ya-yaudahlah..."
    );
    #endregion

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_18 = new LocalizationString(
        "Uhh... anyway, roll the credit!",
        "Err... anyway, roll the credit!"
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_19 = new LocalizationString(
        "Don't worry, it's just a moment haha.",
        "Santai aja kok, cuma sebentar wkwk."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_20 = new LocalizationString(
        "See? It's just a moment haha.",
        "Halo halo, tuhkan creditnya sebentar wkwk"
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_21 = new LocalizationString(
        "Well, I want to say, THANKS FOR PLAYING MY GAME!",
        "Terus juga gua pengen bilang, MAKASIH YA UDAH MAININ GAME GUA!"
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_22 = new LocalizationString(
        "If this game have a lot of supporter, I'm planning to make this game uhh... fuller.",
        "Kalau semisalnya banyak yang support, gua berencana bikin yang lebih full."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_23 = new LocalizationString(
        "And I hope lot of people support me haha.",
        "Dan gua harap sih banyak yang support wkwk."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_24 = new LocalizationString(
        "Unfortunately, if it exist, I will not remember that you have play this game, I'm sorry.",
        "Sayangnya kalau ada, gua gabakalan inget lu pernah mainin game ini, maaf ya."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_25 = new LocalizationString(
        "So, before I forget, I just want to say thank you very much for playing & support this game.",
        "Jadi sebelum gua lupa, gua pengen bilang makasih banget udah mainin & support game ini."
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_26 = new LocalizationString(
        "What are you going to do now, Agent Violet?\n(Player Feedback Survey will be open. Please don't panic.)",
        "Apa yang mau lu lakukan sekarang, Agent Violet?\n(Survey Feedback Pemain akan dibuka. Harap jangan panik.)"
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_26_0 = new LocalizationString(
        "Start from beginning again (Clear save & new game)",
        "Mulai dari awal lagi (Ulang dari awal)"
    );

    public static readonly LocalizationString VW_ONLOAD_ENDGAME_26_1 = new LocalizationString(
        "Goodbye! (Quit)",
        "Dadah! (Keluar)"
    );
    #endregion

    #region Load Game
    public static readonly LocalizationString VW_ONLOAD_LOADGAME = new LocalizationString(
        "Agent Violet. Get back to work, you still have to investigate Ubivision right?",
        "Agent Violet. Kerja oy, lu masih menjalankan misi investigasi perusahaan Ubivision kan?"
    );
    
    public static readonly LocalizationString VW_ONLOAD_LOADGAME_CHOICES_1 = new LocalizationString(
        "Ah, excuse me. (Continue)",
        "Eiya, punten. (Lanjutkan permainan)"
    );
    
    public static readonly LocalizationString VW_ONLOAD_LOADGAME_CHOICES_2 = new LocalizationString(
        "Huh? Of course not, what are you talking about! (New game)",
        "Hah? Engga kok, ngablu kali lu! (Ulang dari awal)"
    );

    public static readonly LocalizationString VW_ONLOAD_LOADGAME_CHOICES_3 = new LocalizationString(
        "Nah, I don't want to work. (Quit)",
        "Engga ah, males kerja. (Keluar)"
    );

    public static readonly LocalizationString VW_CLEARSAVEGAME = new LocalizationString(
        "A-Are you serious? Does this mean that all of this is just my imagination?",
        "Se-seriusan? Berarti selama ini cuma khayalan doang?"
    );

    public static readonly LocalizationString VW_CLEARSAVEGAME_CHOICES_1 = new LocalizationString(
        "I really want to start from 0, so bye! (Clear save & new game)",
        "Emang mau dari awal lagi sih, dadah! (Hapus & ulang dari awal)"
    );

    public static readonly LocalizationString VW_CLEARSAVEGAME_CHOICES_2 = new LocalizationString(
        "Juuuustt kidding! (Continue)",
        "Gaddeeeeng! (Lanjutkan permainan)"
    );
    #endregion

    #region Start Game
    static readonly string vw_onload_0 = "54 65 73 74 20 74 65 73 74 2E 20 48 61 6C 6F 20 41 67 65 6E 74 20 56 69 6F 6C 65 74";
    public static readonly LocalizationString VW_ONLOAD_0 = new LocalizationString(vw_onload_0, vw_onload_0, vw_onload_0);

    static readonly string vw_onload_0_1 = "Can you speak English? (English)";
    static readonly string vw_onload_0_2 = "Gabisa basa Enggres... (Bahasa Indonesia)";
    public static readonly LocalizationString VW_ONLOAD_0_1 = new LocalizationString(vw_onload_0_1, vw_onload_0_1, vw_onload_0_1);
    public static readonly LocalizationString VW_ONLOAD_0_2 = new LocalizationString(vw_onload_0_2, vw_onload_0_2, vw_onload_0_2);

    public static readonly LocalizationString VW_ONLOAD_1 = new LocalizationString(
        "Ah, excuse me. I forgot to change the language haha.\n(Darn, My English grammar sucks. Well who cares anyway~)",
        "Ah, punten. Gua lupa ganti bahasanya wkwk.\n(Gua ga ngerti Bahasa Indonesia KBBI sih, bodo amet lah ya~)"
    );

    public static readonly LocalizationString VW_ONLOAD_2 = new LocalizationString(
        "Err... Anyway...",
        "Err... Anyway..."
    );

    public static readonly LocalizationString VW_ONLOAD_3 = new LocalizationString(
        "NYEHEHEHEHE!",
        "NYEHEHEHEHE!"
    );

    public static readonly LocalizationString VW_ONLOAD_4 = new LocalizationString(
        "WELCOME TO THE WORLD THAT I MADE, PLAYER!",
        "SELAMAT DATANG DI DUNIA YANG GUA BIKIN, PLAYER!"
    );

    public static readonly LocalizationString VW_ONLOAD_5 = new LocalizationString(
        "I AM \"The Developer\"!",
        "KENALIN, GUA \"The Developer\"!"
    );

    public static readonly LocalizationString VW_ONLOAD_6 = new LocalizationString(
        "Uhh... maybe you know me from the future or from the past...",
        "Err... mungkin lu pernah kenal gua dari masa depan atau dari masa lalu..."
    );

    public static readonly LocalizationString VW_ONLOAD_7 = new LocalizationString(
        "But it's okay. Let me introduce myself again.",
        "Tapi gapapa, kenalan lagi kalau udah kenal."
    );

    public static readonly LocalizationString VW_ONLOAD_8 = new LocalizationString(
        "Nyehehehe...",
        "Nyehehehe..."
    );

    public static readonly LocalizationString VW_ONLOAD_9 = new LocalizationString(
        "Hehe.",
        "Hehe."
    );

    public static readonly LocalizationString VW_ONLOAD_10 = new LocalizationString(
        "IN THIS GAME, YOU ARE A SPY!",
        "DI GAME INI, LU BAKALAN JADI SEORANG SPY!"
    );

    public static readonly LocalizationString VW_ONLOAD_11 = new LocalizationString(
        "YOUR MISSION IS TO INFILTRATE A COMPANY CALLED UBIVISION!",
        "TUGAS LU SEKARANG ADALAH INFILTRASI PERUSAHAAN UBIVISION!"
    );

    public static readonly LocalizationString VW_ONLOAD_12 = new LocalizationString(
        "THERE IS A RUMOR SAYING THAT THE COMPANY VIOLATES THE RIGHT OF WORKERS, ESPECIALLY WOMEN WORKERS!",
        "ADA RUMOR MENGATAKAN KALAU PERUSAHAAN TERSEBUT MELANGGAR HAK-HAK PEKERJA, TERUTAMA PEKERJA PEREMPUAN!"
    );

    public static readonly LocalizationString VW_ONLOAD_13 = new LocalizationString(
        "FIND OUT WHETHER THAT RUMOR IS TRUE OR FALSE AND FIND THE EVIDENCE IF IT IS TRUE!",
        "CARI TAHU APAKAH RUMOR TERSEBUT BENAR ATAU TIDAK DAN CARI BUKTINYA JIKA RUMOR TERSEBUT MEMANG BENAR!"
    );

    public static readonly LocalizationString VW_ONLOAD_14 = new LocalizationString(
        "It's tiring to always write in caps haha.",
        "Capek euy nulis caps mlulu wkwk."
    );

    public static readonly LocalizationString VW_ONLOAD_15 = new LocalizationString(
        "Are you ready to play this game, Agent Violet?",
        "Udah siap memainkan game ini, Agent Violet?"
    );

    public static readonly LocalizationString VW_ONLOAD_15_0 = new LocalizationString(
        "I'm ready. (New game)",
        "Oke, siap. (Mulai game)"
    );

    public static readonly LocalizationString VW_ONLOAD_15_1 = new LocalizationString(
        "Nah. (Quit)",
        "Engga ah, males. (Keluar)"
    );

    public static readonly LocalizationString VW_ONLOAD_16 = new LocalizationString(
        "Alright! Before you play the game, is there any question?",
        "Sip! Sebelum mulai gamenya, ada pertanyaan ga?"
    );

    public static readonly LocalizationString VW_ONLOAD_17 = new LocalizationString(
        "No?",
        "Ga ada?"
    );

    public static readonly LocalizationString VW_ONLOAD_18 = new LocalizationString(
        "Of course not, I don't even make the dialogues for it, NYEHEHEHEHE.",
        "Welp, bukannya ga ada sih, gua emang ga ngasih pilihan buat pertanyaan, NYEHEHEHEHE."
    );

    public static readonly LocalizationString VW_ONLOAD_19 = new LocalizationString(
        "Uhh... I'm preparing the teleportation system for you to teleport you to the Hub World.",
        "Err... gua lagi siapin teleportase lu ke Hub World."
    );

    public static readonly LocalizationString VW_ONLOAD_20 = new LocalizationString(
        "When you get there, interact with my laptop where it is located an the end of the Hub World to sneak teleport you to Ubivision.",
        "Sampai disana, nanti lu interaksi sama laptop gua yang berada di ujung Hub World biar lu bisa teleport ke perusahaan Ubivision."
    );

    public static readonly LocalizationString VW_ONLOAD_21 = new LocalizationString(
        "And also, after teleporting you from here, you can't contact me anymore.",
        "Dan juga, sehabis teleportase dari sini, lu udah ga bisa kontak gua lagi."
    );

    public static readonly LocalizationString VW_ONLOAD_22 = new LocalizationString(
        "Okay! The teleportation system is ready!",
        "Sip, teleportase udah siap!"
    );

    public static readonly LocalizationString VW_ONLOAD_23 = new LocalizationString(
        "You will be teleported in ...",
        "Teleportase akan dibuka dalam waktu ..."
    );

    #endregion
    #endregion

    #region Hub World
    public static readonly LocalizationString HW_WIN = new LocalizationString(
        "Nothing happened...",
        "Ga terjadi apa-apa..."
    );

    #region 3DSR
    public static readonly LocalizationString HW_DETAIL_3DSR_0 = new LocalizationString(
        "Note from The Developer :",
        "Pesan dari The Developer :"
    ); 
    
    public static readonly LocalizationString HW_DETAIL_3DSR_1 = new LocalizationString(
        "This is NPC 3D Headphone Sphere Robot from 3D Sphere Robot class.",
        "Ini NPC 3D Headphone Spehere Robot dari kelas 3D Sphere Robot."
    );

    public static readonly LocalizationString HW_DETAIL_3DSR_2 = new LocalizationString(
        "They work in Ubivision as guard in that place, guarding it from spy like you.",
        "Mereka tugasnya di perusahaan Ubivision sebagai satpam di tempat tersebut, menjaga dari spy kayak lu."
    );

    public static readonly LocalizationString HW_DETAIL_3DSR_3 = new LocalizationString(
        "It's true that they're the enemies in this game, but you can't kill / takedown them.",
        "Mereka memang antagonis di game ini, tapi lu ga boleh dan ga bisa bunuh mereka."
    );

    public static readonly LocalizationString HW_DETAIL_3DSR_6 = new LocalizationString(
        "If you get caught by them, just do a time leap.",
        "Kalo lu ketangkep sama mereka, ntar lu tinggal time leap aja."
    );

    public static readonly LocalizationString HW_DETAIL_3DSR_7 = new LocalizationString(
        "You will be reverted to the last checkpoint.",
        "Ntar lu balik ke checkpoint terakhir."
    );

    public static readonly LocalizationString HW_DETAIL_3DSR_8 = new LocalizationString(
        "OH OH! AND ALSO! I nearly completely forgot.",
        "EH BENTAR, nyaris lupa gua."
    );

    public static readonly LocalizationString HW_DETAIL_3DSR_9 = new LocalizationString(
        "They're all using noise-cancelling headphones, so they can't hear you when you're running.",
        "Mereka semua menggunakan headphone noise cancelling, jadi mereka nggak bakalan bisa denger kalau lu lari."
    );
    #endregion

    #region BD
    public static readonly LocalizationString HW_DETAIL_BD_0 = new LocalizationString(
        "Note from The Developer :",
        "Pesan dari The Developer :"
    );

    public static readonly LocalizationString HW_DETAIL_BD_1 = new LocalizationString(
        "This is Ubivision.",
        "Ini adalah perusahaan Ubivision."
    );

    public static readonly LocalizationString HW_DETAIL_BD_2 = new LocalizationString(
        "Just like other company, this company is located inside 3D Titan Sphere Robot.",
        "Sama kayak perusahaan lainnya, perusahaan ini terletak didalam 3D Titan Sphere Robot."
    );

    public static readonly LocalizationString HW_DETAIL_BD_3 = new LocalizationString(
        "Ubivision is a video game company.",
        "Perusahaan ini bergerak di industri game."
    );

    public static readonly LocalizationString HW_DETAIL_BD_4 = new LocalizationString(
        "Rumor says that this company violates their workers' rights, especially women workers",
        "Rumor mengatakan bahwa perusahaan ini melanggar hak asasi pekerja mereka, terutama pekerja perempuan."
    );

    public static readonly LocalizationString HW_DETAIL_BD_5 = new LocalizationString(
        "Like there is a lot of discrimination against pregnant female employees who are not allowed to take leave, etc.",
        "Seperti karyawan perempuan hamil yang tidak boleh cuti, banyak diskriminasi, dan lain-lain."
    );

    public static readonly LocalizationString HW_DETAIL_BD_6 = new LocalizationString(
        "Your mission is to investigate and infiltrate this company, whether it's true or not.",
        "Nah tugas lu investigasi perusahaan ini, apakah benar atau tidak rumor tersebut."
    );

    public static readonly LocalizationString HW_DETAIL_BD_7 = new LocalizationString(
        "Unfortunately, there isn't lot of information about who is the man behind all of this.",
        "Sayangnya tidak ada informasi mengenai siapa pemilik dari perusahaan ini."
    );
    #endregion

    #region 3DH
    public static readonly LocalizationString HW_DETAIL_3DH_0 = new LocalizationString(
        "Note from The Developer :",
        "Pesan dari The Developer :"
    );

    public static readonly LocalizationString HW_DETAIL_3DH_1 = new LocalizationString(
        "This is you, Agent Violet, you're the best spy in this game.",
        "Ini lu, Agent Violet, lu adalah spy terbaik di game ini."
    );

    public static readonly LocalizationString HW_DETAIL_3DH_2 = new LocalizationString(
        "You're from 3D Humanoid class, a class with few characters.",
        "Lu berasal dari kelas 3D Humanoid, kelas yang jarang ada karakternya."
    );

    public static readonly LocalizationString HW_DETAIL_3DH_10 = new LocalizationString(
        "And also, because there are a lot of testers that don't know this, I need to tell you something.",
        "Dan juga, karena banyak tester yang ga nyadar ini, ada yang pengen gua kasih tau nih."
    );

    public static readonly LocalizationString HW_DETAIL_3DH_11 = new LocalizationString(
        "This game have synchronous movement, so what is synchronous?",
        "Game ini adalah game synchronous, apa itu synchronous?"
    );

    public static readonly LocalizationString HW_DETAIL_3DH_14 = new LocalizationString(
        "It's a turn based but players and enemies use their turn together.",
        "Intinya ini turn base tapi musuh dan player bergerak bersama."
    );

    public static readonly LocalizationString HW_DETAIL_3DH_15 = new LocalizationString(
        "So use your turn as wisely as possible.",
        "Jadi gunakan turn mu sebijak mungkin."
    );
    #endregion

    #region 2DH
    public static readonly LocalizationString HW_DETAIL_2DH_0 = new LocalizationString(
        "Note from The Developer :",
        "Pesan dari The Developer :"
    );

    public static readonly LocalizationString HW_DETAIL_2DH_1 = new LocalizationString(
        "No, this isn't my laptop.",
        "Enggak, ini bukan laptop gua."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_2 = new LocalizationString(
        "This is the interface for class 2D Humanoid, they're all employees in Ubivision.",
        "Ini interface berbentuk monitor dari NPC kelas 2D Humanoid, mereka adalah karyawan di perusahaan Ubivision."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_3 = new LocalizationString(
        "They all need interfaces because they lives in different dimensions.",
        "Mereka semua butuh interface karena mereka semua hidup di dimensi yang berbeda."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_4 = new LocalizationString(
        "To move from interface to other interface, they're using the internet.",
        "Untuk pindah dari interface ke interface lain, mereka menggunakan internet."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_5 = new LocalizationString(
        "If there's no electricity or the wifi is down, they will be trapped in the interface until they turn into static objects.",
        "Jika listrik mati atau wifi mati, mereka akan terperangkap di interface tersebut sampai mereka berubah menjadi objek statis."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_6 = new LocalizationString( 
        "But you will not meet them directly in this game.",
        "Tapi lu ga bakalan ketemu mereka secara langsung sih di game ini."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_9 = new LocalizationString(
        "And also, there is NPC 2D 1 Bit.",
        "Terus juga ada NPC kelas 2D 1 Bit."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_10 = new LocalizationString(
        "Just like 2D Humanoid, they also need an interface to live.",
        "Sama kayak 2D Humanoid, mereka juga butuh interface untuk hidup."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_11 = new LocalizationString(
        "But the different is this class have simple design and only have 1 bit color.",
        "Namun bedanya kelas ini desain karakternya simple dan hanya punya warna 1 Bit."
    );

    public static readonly LocalizationString HW_DETAIL_2DH_12 = new LocalizationString(
        "You will often meet them in this game.",
        "Lu bakalan sering ketemu kelas 2D 1 Bit di game ini kok."
    );
    #endregion

    #endregion

    #region UV1
    public static readonly LocalizationString UV1_DOORNOSWITCH = new LocalizationString(
        "There's no one in this door...",
        "Pintunya ga ada penghuninya..."
    ); 
    
    public static readonly LocalizationString UV1_DOORNOPASSWORD = new LocalizationString(
        "You don't have a password for this door...",
        "Ga punya password buat pintu ini..."
    );

    public static readonly LocalizationString[] UV1_PASSWORD_CHOICES = new LocalizationString[3]
    {
        new LocalizationString("Enter Password.", "Masukkan Password."),
        new LocalizationString("Enter Password (Already have the answers).", "Masukkan Password (Sudah punya jawabannya)."),
        new LocalizationString("Cancel.", "Gajadi.")
    };

    public static readonly LocalizationString[] UV1_PASSWORD_QUESTION = new LocalizationString[9]
    {
        new LocalizationString("Question #1", "Pertanyaan #1"),
        new LocalizationString("Question #2", "Pertanyaan #2"),
        new LocalizationString("Question #3", "Pertanyaan #3"),
        new LocalizationString("Question #4", "Pertanyaan #4"),
        new LocalizationString("Question #5", "Pertanyaan #5"),
        new LocalizationString("Question #6", "Pertanyaan #6"),
        new LocalizationString("Question #7", "Pertanyaan #7"),
        new LocalizationString("Question #8", "Pertanyaan #8"),
        new LocalizationString("Question #9", "Pertanyaan #9")
    };

    public static readonly LocalizationString[] UV1_PASSWORD_ANSWER = new LocalizationString[3]
    {
        new LocalizationString("1", "1"),
        new LocalizationString("2", "2"),
        new LocalizationString("3", "3")
    };

    public static readonly LocalizationString UV1_MEMORY_TRIGGERED = new LocalizationString(
        "There are many voices from the past heard through this crack of time...",
        "Ada banyak suara dari masa lalu terdengar di pecahan waktu ini..."
    );

    public static readonly LocalizationString UV1_MEMORY_REMEMBERED_0 = new LocalizationString(
        "You magically remember all of the dialogues...",
        "Secara tiba-tiba hapal semua dialog barusan..."
    );

    public static readonly LocalizationString UV1_MEMORY_REMEMBERED_1 = new LocalizationString(
        "Maybe those dialogues can be used as a password for a door!",
        "Mungkin dialog-dialog tersebut bisa dipakai untuk password di pintu tertentu!"
    );

    #region OPEN DOOR1
    public static readonly LocalizationString UV1_OPENDOOR1_0 = new LocalizationString(
        "Hello and hi!",
        "Halo dan hi!"
    );

    public static readonly LocalizationString UV1_OPENDOOR1_1 = new LocalizationString(
        "Welcome to Ubivision!",
        "Selamat datang di perushaan Ubivision!"
    );

    public static readonly LocalizationString UV1_OPENDOOR1_2 = new LocalizationString(
        "Tonight we have a power failure, so that's why there aren't many employees working.",
        "Saat ini lagi mati lampu sih, makanya cuma sedikit yang kerja."
    );

    public static readonly LocalizationString UV1_OPENDOOR1_3 = new LocalizationString(
        "Usually there are a lot of employees crunching, they are all really hard workers!",
        "Biasanya jam segini masih pada kerja lembur, hebat deh karyawan disini!"
    );

    public static readonly LocalizationString UV1_OPENDOOR1_4 = new LocalizationString(
        "What?",
        "Kenapa?"
    );

    public static readonly LocalizationString UV1_OPENDOOR1_5 = new LocalizationString(
        "Do you want to get rid of me and go this way?",
        "Anda mau menyingkirkan saya dan lewat sini?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR1_5_CHOICES = new LocalizationString[2]
    {
        new LocalizationString("Yes.", "Iya."),
        new LocalizationString("No.", "Enggak.")
    };

    public static readonly LocalizationString UV1_OPENDOOR1_5_1 = new LocalizationString(
        "F-Fine!",
        "Ya-Yaudah deh!"
    );
    #endregion

    #region OPEN DOOR TIMING 1
    public static readonly LocalizationString UV1_OPENDOOR_TIMING1_0 = new LocalizationString(
        "Ugghhhh, I really don't want to crunch.",
        "Haddeeeh, males banget ngelembur yaampooon."
    );

    public static readonly LocalizationString UV1_OPENDOOR_TIMING1_1 = new LocalizationString(
        "And they also don't pay the crunch money.",
        "Malah ga dibayar uang lemburnya lagi."
    );

    public static readonly LocalizationString UV1_OPENDOOR_TIMING1_2 = new LocalizationString(
        "Huh? What? Do you want to open the door over there?",
        "Hah? Apaan? Lu mau gua buka pintu sebelah sana?"
    );

    public static readonly LocalizationString UV1_OPENDOOR_TIMING1_3 = new LocalizationString(
        "Go ahead, but you must run fast, the door will automatically close.",
        "Tapi lari ya, pintunya bakalan ketutup automatis."
    );

    public static readonly LocalizationString UV1_OPENDOOR_TIMING1_3_CHOICES_0 = new LocalizationString(
        "Yes, please.",
        "Iya, tolong ya."
    );

    public static readonly LocalizationString UV1_OPENDOOR_TIMING1_3_CHOICES_1 = new LocalizationString(
        "Why are you here?",
        "Kenapa lu disini?"
    );

    public static readonly LocalizationString UV1_OPENDOOR_TIMING1_3_CHOICES_1_0 = new LocalizationString(
        "Hmm... Idk lol.",
        "Hmm... Gatau wkwk."
    );
    #endregion

    #region OPEN DOOR PASSWORD 1
    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1 = new LocalizationString(
        "You can't pass here, except if you have the password.",
        "Anda tidak bisa lewat sini, kecuali mempunyai password."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_CHOICES_0_Q_0 = new LocalizationString(
        "Who is our greatest leader?",
        "Siapa pemimpin kami yang maha hebat?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD1_CHOICES_0_Q_0_A = new LocalizationString[3]
    {
        new LocalizationString("Boba Kotak", "Boba Kotak"),
        new LocalizationString("Boobie Kitty", "Boobie Kitty"),
        new LocalizationString("Bobby Kotick", "Bobby Kotick")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_CHOICES_0_Q_1 = new LocalizationString(
        "Which industry Ubivision engaged to?",
        "Perusahaan Ubivision bergerak di industri ..."
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD1_CHOICES_0_Q_1_A = new LocalizationString[3]
    {
        new LocalizationString("Porn Industry", "Industri Pornografi"),
        new LocalizationString("Game Industry", "Industri Game"),
        new LocalizationString("Coconut Oil Industry", "Industri Kelapa Sawit")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_CHOICES_0_Q_2 = new LocalizationString(
        "I'm guarding for departement ...",
        "Saya menjaga untuk departement apa ya?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD1_CHOICES_0_Q_2_A = new LocalizationString[3]
    {
        new LocalizationString("Programmer", "Programmer"),
        new LocalizationString("Artist", "Artist"),
        new LocalizationString("Audio & Sound", "Audio & Sound")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_CHOICES_1_0 = new LocalizationString(
        "Our greatest leader is Boba Kotak...",
        "Pemimpin kami yang maha hebat namanya Boba Kotak..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_CHOICES_1_1 = new LocalizationString(
        "Ubivision engaged in game industry...",
        "Perusahaan Ubivision bergerak di industri game..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_CHOICES_1_2 = new LocalizationString(
        "I guard Audio & Sound departement...",
        "Saya menjaga departement Audio & Sound..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_TRUE = new LocalizationString(
        "The password is... true?",
        "Passwordnya... benar?"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD1_FALSE = new LocalizationString(
        "Pffft, wrong password stupid.",
        "Pffft, passwordnya salah bodoh."
    );
    #endregion

    #region MEMORY PASSWORD 1
    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_0 = new LocalizationString(
        "\"Working overtime is tiring...\"",
        "\"Ngelembur capeeeek...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_1 = new LocalizationString(
        "\"You don't even get paid for working overtime, ugghhh...\"",
        "\"Malah ga digaji duit lemburnya lagi, hadeehh...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_2 = new LocalizationString(
        "\"Working here also has really low salary.\"",
        "\"Terus kerja disini gajinya dikit banget lagi.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_3 = new LocalizationString(
        "\"But Mr. #@($@, his salary is bigger than mine even though he rarely works.\"",
        "\"Terus giliran si Pak #@($@, gajinya lebih gede dari aku padahal dia jarang kerja.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_4 = new LocalizationString(
        "\"I have tried to request a salary increase.\"",
        "\"Aku pernah minta ke atasan buat minta naikin gaji.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_5 = new LocalizationString(
        "\"But I was rejected because I am a woman, ughhhhh...\"",
        "\"Tapi ga dibolehin karena aku cewek, haddeeehh...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_6 = new LocalizationString(
        "\"Ugh, I was trying to get a job at Ubivision because I'm interested with game industry...\"",
        "\"Hadeh, padahal aku daftar di perusahaan Ubivision karena penasaran dengan Industri Game gimana...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_7 = new LocalizationString(
        "\"But now I feel like I want to punch the face of the owner of this company, Boba Kotak.\"",
        "\"Tapi sekarang rasanya pengen nonjok kepalanya pemilik perusahaan ini, Boba Kotak.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_8 = new LocalizationString(
        "\"Oh, and also, because departement Audio & Sound is located the furthest and being minority, we always get discriminated by other departement...\"",
        "\"Terus juga gegara departement Audio & Sound letaknya paling jauh dan minoritas, kita jadi sering kena diskriminasi sama departement lain huhu...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD1_9 = new LocalizationString(
        "\"I WANT TO LEAVE FROM THIS COMPANY BUT I NEED MONEY AAAAAAA!\"",
        "\"PENGEN CABUT DARI PERUSAHAAN INI TAPI BUTUH DUIT AAAAAAA!\""
    );
    #endregion

    #region CLOSE DOOR 1
    public static readonly LocalizationString UV1_CLOSEDOOR1_0 = new LocalizationString(
        "Do you want to close the door so that robot can't see you?",
        "Lu mau gua tutup pintunya biar robotnya ga bisa liat lu?"
    );

    public static readonly LocalizationString UV1_CLOSEDOOR1_0_CHOICES_0 = new LocalizationString(
        "Sure.",
        "Boleh."
    );

    public static readonly LocalizationString UV1_CLOSEDOOR1_0_CHOICES_0_0 = new LocalizationString(
        "Well, thank goodness they're all stupid, so they will not notice it lol.",
        "Untungnya mereka bego, jadi mereka ga bakalan nyadar wkwk."
    );

    public static readonly LocalizationString UV1_CLOSEDOOR1_0_CHOICES_1 = new LocalizationString(
        "Nah.",
        "Gausah deh."
    );
    #endregion

    #region OPEN DOOR PASSWORD 2
    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_0 = new LocalizationString(
        "YOU CAN'T PASS THE WAY TO WAREHOUSE!!!",
        "ANDA TIDAK BOLEH MELEWATI JALAN KE GUDANG!!!"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_1 = new LocalizationString(
        "Except if you have the password.",
        "Kecuali punya password."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_CHOICES_0_Q_0 = new LocalizationString(
        "What is the class of our greatest leader?",
        "Pemimpin kami yang maha hebat termasuk kelas apa ya?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD2_CHOICES_0_Q_0_A = new LocalizationString[3]
    {
        new LocalizationString("3D Sphere Robot", "3D Sphere Robot"),
        new LocalizationString("3D Humanoid", "3D Humanoid"),
        new LocalizationString("2D Humanoid", "2D Humanoid")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_CHOICES_0_Q_1 = new LocalizationString(
        "What is the percentage of workers in Ubivision between male, female, and neutral?",
        "Berapa persentase pekerja antara pria, wanita, dan neutral di perusahaan Ubivision?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD2_CHOICES_0_Q_1_A = new LocalizationString[3]
    {
        new LocalizationString("60%, 10%, 30%", "60%, 10%, 30%"),
        new LocalizationString("30%, 30%, 40%", "30%, 30%, 40%"),
        new LocalizationString("100%, 100%, 100%", "100%, 100%, 100%")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_CHOICES_0_Q_2 = new LocalizationString(
        "How tall and heavy is our greatest leader?",
        "Berapa tinggi dan berat pemimpin kami yang maha hebat?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD2_CHOICES_0_Q_2_A = new LocalizationString[3]
    {
        new LocalizationString("0.00169km 6969Oz", "0.00169km 6969Oz"),
        new LocalizationString("6.9Feet 169lbs", "6.9Feet 169lbs"),
        new LocalizationString("169cm 69kg", "169cm 69kg")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_CHOICES_1_0 = new LocalizationString(
        "Our greatest leader is 2D Humanoid...",
        "Pemimpin kami yang maha hebat termasuk kelas 2D Humanoid..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_CHOICES_1_1 = new LocalizationString(
        "Ubivision workers percentage is 60% male, 10% female, and 30% neutral...",
        "Persentase pekerja di perusahaan Ubivision yaitu 60% pria, 10% wanita, dan 30% neutral..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_CHOICES_1_2 = new LocalizationString(
        "Our greatest leader is 169cm with 69kg",
        "Pemimpin kami yang maha hebat tingginya 169cm dengan berat 69kg..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_TRUE = new LocalizationString(
        "Correct!",
        "Benar!"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD2_FALSE = new LocalizationString(
        "Wrong!",
        "Salah!"
    );
    #endregion

    #region MEMORY PASSWORD 2
    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_0 = new LocalizationString(
        "\"Honey~ I'm pregnant.\"",
        "\"Sayang~ Aku hamil.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_1 = new LocalizationString(
        "\"I don't care.\"",
        "\"Bodo.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_2 = new LocalizationString(
        "\"Well, there is no leave here for preganante women.\"",
        "\"Ya abis gimana, disini kan ga ada cuti buat cewek hamil.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_3 = new LocalizationString(
        "\"You still fortunate because there is a female worker from other department that fired because she was pregarant.\"",
        "\"Untung ga kena phk kayak cewek dari departement sebelah gegara hamil.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_4 = new LocalizationString(
        "\"Because Boba Kotak is 2D Humanoid who can't pragant, Boba Kotak violates our rights like this...\"",
        "\"Mentang-mentang Boba Kotak kelasnya 2D Humanoid yang ga bisa hamil, tapi ya ga gini juga sih...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_5 = new LocalizationString(
        "\"Excuse me sir, my baby is crying and need breast feed.\"",
        "\"Permisi atasan, bayi saya nangis dan butuh susu.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_6 = new LocalizationString(
        "\"Can I take a break to breast feed my baby?\"",
        "\"Saya izin untuk menyusui bayi saya sebentar ya?\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_7 = new LocalizationString(
        "\"WORKERS CAN'T LEAVE THEIR DESK!\"",
        "\"PEKERJA TIDAK BOLEH MENINGGALKAN KERJAANNYA!\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_8 = new LocalizationString(
        "\"PERCENTAGE BETWEEN MALE, FEMALE AND NEUTRAL IN UBIVISION IS 60%, 10%, AND 30%.\"",
        "\"PERSENTASE PRIA WANITA DAN NEUTRAL DI PERUSAHAAN UBIVISION YAITU 60%, 10%, DAN 30%.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_9 = new LocalizationString(
        "\"THAT'S WHY WOMAN CAN'T TAKE A BREAK TO BREAST FEED WHILE WORKING.\"",
        "\"ITULAH SEBABNYA WANITA TIDAK BERHAK ISTIRAHAT UNTUK MENYUSUI KETIKA KERJA.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_10 = new LocalizationString(
        "\"We-Well then, let me just breast feed here...\"",
        "\"Ya-yaudah menyusui disini deh...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_11 = new LocalizationString(
        "\"Do you know how tall and heavy Boba Kotak?",
        "\"Eh, tinggi dan beratnya Boba Kotak berapaan sih?\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_12 = new LocalizationString(
        "\"Why are you asking about that?\"",
        "\"Lu nanya gituan buat apaan?\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_13 = new LocalizationString(
        "\"Ah, for drawing reference.\"",
        "\"Oh buat referensi gambar ya.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_14 = new LocalizationString(
        "\"I occasionally forgot that we work on Artist departement haha.\"",
        "\"Kadang gua lupa kalo kita kerja di departement Artist wkwk.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_15 = new LocalizationString(
        "\"Mr. Kotak is 169cm and 69kg.\"",
        "\"Tinggi Pak Boba Kotak 169Cm beratnya 69kg.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_16 = new LocalizationString(
        "\"Speaking of Mr. Kotak.\"",
        "\"Tapi anjirlah Pak Boba Kotak.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD2_17 = new LocalizationString(
        "\"That guy really don't give credit for artist in the game, darn it.\"",
        "\"Masa artist di perusahaan ini engga di cantumin namanya di game, ckck.\""
    );
    #endregion

    #region OPEN DOOR PASSWORD 3
    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD3_0 = new LocalizationString(
        "Zzz... I'm tired...",
        "Zzz... ngantuk..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD3_1 = new LocalizationString(
        "You... can't pass here...",
        "Kamu... ga boleh lewat sini..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD3_2 = new LocalizationString(
        "You need the password... but I'm too lazy to make it, zzz...",
        "Butuh password... tapi aku males bikin pertanyaannya sih zzz..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD3_CHOICES_1_0 = new LocalizationString(
        "The password is 2 2 2...",
        "Passwordnya 2 2 2..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD3_TRUE = new LocalizationString(
        "Right...",
        "Benar..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD3_FALSE = new LocalizationString(
        "Wrong...",
        "Salah..."
    );
    #endregion

    #region MEMORY PASSWORD 3
    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_0 = new LocalizationString(
        "\"Sigh... I need to go to school tomorrow...\"",
        "\"Aduh... Besok harus pergi ke sekolah lagi...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_1 = new LocalizationString(
        "\"Wait, not tomorrow, but in the morning!\"",
        "\"Eh! Enggak besok deng, tapi nanti pagi!\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_2 = new LocalizationString(
        "\"I just finished the work and it's already 1 am...\"",
        "\"Ini udah jam 1 pagi, baru aja selesai kerjaannya...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_3 = new LocalizationString(
        "\"Also, I'm really hungry...\"",
        "\"Malah aku laper banget lagi...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_4 = new LocalizationString(
        "\"High school workers here have a low salary, must work overtime, and are not given food.\"",
        "\"Parah banget, anak SMA udah kerjanya digaji sedikit, harus lembur, enggak dikasih makanan lagi.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_5 = new LocalizationString(
        "\"Oh well, I really need money.\"",
        "\"Yaudahlah, lagi butuh duit sih.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_6 = new LocalizationString(
        "\"This company doesn't provide transportation for workers that are going home at this hour...\"",
        "\"Aduh dari kantor enggak kasih transportasi kalau pulang jam segini...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_7 = new LocalizationString(
        "\"High school girls going home alone at this hour is fine right? ... right?\"",
        "\"Cewek SMA pulang jam segini sendirian gapapa kan ya? ... ya kan?\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_8 = new LocalizationString(
        "\"WAIT, WHAT IS THE PASSWORD FOR THIS DOOR, I FORGOT AAAAAA!\"",
        "\"EHHH INI PINTU PASSWORDNYA APA AKU LUPAAAA!\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_9 = new LocalizationString(
        "\"HOW DO I GO HOME AAAAAA!\"",
        "\"GMANA MAU PULANG INI AAAAAAA!\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD3_10 = new LocalizationString(
        "\"Ah yes, the password is 2 2 2.\"",
        "\"Oiya 2 2 2.\""
    );
    #endregion

    #region OPEN DOOR PASSWORD 4
    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_0 = new LocalizationString(
        "I will protect Elefataa and I will die for Elefataa!!!",
        "Saya akan melindungi Elefataa dengan segala hal!!!"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_1 = new LocalizationString(
        "You will never find the password and you will never pass this way!",
        "Anda tidak akan pernah menemukan passwordnya dan anda tidak akan pernah melewati jalan ini!"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_CHOICES_0_Q_0 = new LocalizationString(
        "Where did our greatest leader graduate?",
        "Pemimpin kami yang maha hebat lulusan mana ya?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD4_CHOICES_0_Q_0_A = new LocalizationString[3]
    {
        new LocalizationString("University of X.", "University of X."),
        new LocalizationString("Drop Out.", "Drop Out."),
        new LocalizationString("Institute Technology Y.", "Institute Technology Y.")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_CHOICES_0_Q_1 = new LocalizationString(
        "When Ubivision founded?",
        "Kapan perusahaan Ubivision didirikan?"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD4_CHOICES_0_Q_1_A = new LocalizationString[3]
    {
        new LocalizationString("4 years ago.", "4 tahun yang lalu."),
        new LocalizationString("69 years ago.", "69 tahun yang lalu."),
        new LocalizationString("13 years ago.", "13 tahun yang lalu.")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_CHOICES_0_Q_2 = new LocalizationString(
        "And the last thing, please fill out this captcha :",
        "Dan terakhir, tolong isi captcha ini :"
    );

    public static readonly LocalizationString[] UV1_OPENDOOR_PASSWORD4_CHOICES_0_Q_2_A = new LocalizationString[3]
    {
        new LocalizationString("I'm not a employee.", "Saya bukan karyawan."),
        new LocalizationString("I'm not a robot.", "Saya bukan robot."),
        new LocalizationString("I'm not a spy.", "Saya bukan spy.")
    };

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_CHOICES_1_0 = new LocalizationString(
        "Our greatest leader is a drop out...",
        "Pemimpin kami yang maha hebat itu drop out..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_CHOICES_1_1 = new LocalizationString(
        "Ubivision founded 4 years ago...",
        "Ubivision didirikan 4 tahun yang lalu..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_CHOICES_1_2 = new LocalizationString(
        "And you managed to fill out captcha that you aren't spy...",
        "Dan Anda berhasil melewati captcha Saya bukan spy..."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_TRUE_0 = new LocalizationString(
        "Oh, it's actually fine.",
        "Oh, ternyata tidak apa-apa."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_TRUE_1 = new LocalizationString(
        "You have proven to be not a spy.",
        "Anda terbukti bukan spy kok."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_TRUE_2 = new LocalizationString(
        "Go ahead!",
        "Silahkan lewat!"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_TRUE_3 = new LocalizationString(
        "As long as you don't go to top floor please, beacause that is our greatest leader's floor.",
        "Asal jangan ke lantai paling atas ya, karena itu lantainya pemimpin kami yang maha hebat."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD4_FALSE = new LocalizationString(
        "There is no one that can pass us!",
        "Tidak akan ada yang bisa melewati kami!"
    );
    #endregion

    #region MEMORY PASSWORD 4
    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_0 = new LocalizationString(
        "\"Finally I got job in Ubivision...\"",
        "\"Akhirnya kerja di perusahaan Ubivision juga...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_1 = new LocalizationString(
        "\"The test to go here is really hard.\"",
        "\"Susah banget masuk sini yak.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_2 = new LocalizationString(
        "\"Even though Mr. Kotak is a drop out from the same university as me...\"",
        "\"Padahal Pak Kotak alumni universitas yang sama kayak gua, walaupun dia drop out sih...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_3 = new LocalizationString(
        "\"But it's really weird, my boyfriend who has a lower score than mine, finds it easier to come here.\"",
        "\"Tapi aneh dah, cowok gua yang nilainya dibawah gua kenapa lebih gampang masuk sini yak.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_4 = new LocalizationString(
        "\"Was it because I'm a fresh grad girl?\"",
        "\"Apakah karena gua fresh grad cewek?\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_5 = new LocalizationString(
        "\"Nah, let's not think like that.\"",
        "\"Ah engga, jangan mikir yang gitu-gitu.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_6 = new LocalizationString(
        "\"I just started working here haha!\"",
        "\"Baru aja mulai kerja wkwk.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_7 = new LocalizationString(
        "\"This company was just founded 4 years ago, but they suddenly made really famous IP.\"",
        "\"Gokil sih, ini perusahaan baru aja didiriin 4 tahun yang lalu, langsung bikin IP terkenal.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_8 = new LocalizationString(
        "\"Even though their training program sucks.\"",
        "\"Tapi pelatihannya parah banget dah.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_9 = new LocalizationString(
        "\"Like I mean, yesterday I was asking my senior about game design...\"",
        "\"Masa kemaren gua nanya ke atasan soal game design gitu...\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_10 = new LocalizationString(
        "\"And my senior don't want to help me because I'm a girl.\"",
        "\"Terus ga dibantuin karena gua cewek katanya.\""
    );

    public static readonly LocalizationString UV1_MEMORY_PASSWORD4_11 = new LocalizationString(
        "\"What is wrong with this company...\"",
        "\"Ampuun dahh, ini perusahaan kenapa dah...\""
    );
    #endregion

    #region OPEN DOOR PASSWORD 5
    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD5_0 = new LocalizationString(
        "You will never pass here, except you found guide from the internet or read readme.pdf lol!",
        "Enggak mungkin lu bisa lewatin gua, kecuali lu cari guide di internet atau baca readme.pdf haha!"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD5_TRUE = new LocalizationString(
        "GGWP!",
        "GGWP!"
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD5_FALSE_0 = new LocalizationString(
        "See, there's no way you can pass here.",
        "Tuhkan, ga mungkin lewatin gua."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD5_FALSE_1 = new LocalizationString(
        "This way is only for hardcore gammmerrzzzzzz.",
        "Ini jalan cuma buat hardcore gammerrzzz."
    );

    public static readonly LocalizationString UV1_OPENDOOR_PASSWORD5_FALSE_2 = new LocalizationString(
        "Find another way, this way is just a shortcut.",
        "Cari jalan lain gih, ini jalan cuma shortcut."
    );
    #endregion

    #region ELEFATAA
    public static readonly LocalizationString UV1_ELEFATAA_0 = new LocalizationString(
        "Hello! Welcome to 6th floor!",
        "Halo! Selamat datang di lantai 6!"
    );

    public static readonly LocalizationString UV1_ELEFATAA_1 = new LocalizationString(
        "Where do you want to ride me?",
        "Mau naikki aku ke mana?"
    );

    public static readonly LocalizationString UV1_ELEFATAA_CHOICES_0 = new LocalizationString(
        "Top floor.",
        "Lantai paling atas."
    );

    public static readonly LocalizationString UV1_ELEFATAA_CHOICES_1 = new LocalizationString(
        "Cancel.",
        "Gajadi."
    );
    #endregion

    #region DEVLOG 1
    public static readonly LocalizationString UV1_DEVLOG1_0 = new LocalizationString(
        "Yo yo yo, this is my diary.",
        "Yohohoo, ini diary gua."
    );

    public static readonly LocalizationString UV1_DEVLOG1_1 = new LocalizationString(
        "I suggest you to collect all of my diary in this game.",
        "Gua saranin lu kumpulin diary gua selama main game."
    );

    public static readonly LocalizationString UV1_DEVLOG1_2 = new LocalizationString(
        "You will be rewarded if you manage to find all of it.",
        "Ntar bakalan gua kasih reward lho kalau kekumpul semuanya."
    );
    #endregion

    #region DEVLOG 2
    public static readonly LocalizationString UV1_DEVLOG2_0 = new LocalizationString(
        "Do you know why you can't kill any 3D Sphere Robot?",
        "Tau ga kenapa lu ga bisa bunuh 3D Sphere Robot manapun?"
    );

    public static readonly LocalizationString UV1_DEVLOG2_1 = new LocalizationString(
        "Because I haven't implemented that mechanic yet.",
        "Karena gua memang belum sempet implementasiin mekanik tersebut."
    );
    #endregion

    #region DEVLOG 3
    public static readonly LocalizationString UV1_DEVLOG3_0 = new LocalizationString(
        "Do you know why every 3D Headphone Sphere Robot wear noise-cancelling headphone?",
        "Tau ga kenapa semua 3D Headphone Sphere Robot pakai headphone noise cancelling?"
    );

    public static readonly LocalizationString UV1_DEVLOG3_1 = new LocalizationString(
        "Because I'm too lazy to implemented listening mechanic for enemies.",
        "Karena gua males implementasi listening mechanic buat musuh."
    );
    #endregion

    #region DEVLOG 4
    public static readonly LocalizationString UV1_DEVLOG4_0 = new LocalizationString(
        "You've entered a shortcut that only hardcore gamerz can use.",
        "Lu lagi berada di shortcut khusus untuk gamerz yang hardcore."
    );

    public static readonly LocalizationString UV1_DEVLOG4_1 = new LocalizationString(
        "Congratulation on completing this course.",
        "Gua ucapkan selamat bisa nembus disini."
    );

    public static readonly LocalizationString UV1_DEVLOG4_2 = new LocalizationString(
        "That being said, what a no life, whether you find it on the internet, read readme.pdf, or you try a lot of probabilties.",
        "Dasar no life, antara lu searching di internet, baca readme.pdf atau ga nyoba entah berapa banyak kemungkinannya."
    );

    public static readonly LocalizationString UV1_DEVLOG4_3 = new LocalizationString(
        "Anyway, it's true how you pass here; that robot must be baited and then you slip away.",
        "Anyway, bener jawabannya; robotnya dipancing dulu baru nanti nyelip."
    );

    public static readonly LocalizationString UV1_DEVLOG4_4 = new LocalizationString(
        "That mechanic was used to be introduced in the early game, but my test said it was really hard haha.",
        "Tadinya mau pake mekanik kayak gitu di awal game, tapi pada kesusahan wkwk."
    );
    #endregion

    #region DEVLOG 5
    public static readonly LocalizationString UV1_DEVLOG5_0 = new LocalizationString(
        "I will tell you why you're the best spy in this game.",
        "Gua bakal ngasih tau kenapa lu spy terbaik di dunia ini."
    );

    public static readonly LocalizationString UV1_DEVLOG5_1 = new LocalizationString(
        "Is it because you're good at it?",
        "Apakah karena lu jago?"
    );

    public static readonly LocalizationString UV1_DEVLOG5_2 = new LocalizationString(
        "WRONG!",
        "SALAH!"
    );

    public static readonly LocalizationString UV1_DEVLOG5_3 = new LocalizationString(
        "The answer is because you're the only spy in this game.",
        "Jawabannya karena lu satu-satunya spy di game ini."
    );
    #endregion

    #region DEVLOG 6
    public static readonly LocalizationString UV1_DEVLOG6_0 = new LocalizationString(
        "I'm really bad at programming.",
        "Ini gua ngoding bego dah."
    );

    public static readonly LocalizationString UV1_DEVLOG6_1 = new LocalizationString(
        "Everything that is interactable is an NPC.",
        "Semua yang interactable adalah NPC."
    );

    public static readonly LocalizationString UV1_DEVLOG6_2 = new LocalizationString(
        "That is why there are a lot of door and switch that I made to an NPC.",
        "Makanya banyak pintu dan switch yang sekalian jadi NPC juga."
    );

    public static readonly LocalizationString UV1_DEVLOG6_3 = new LocalizationString(
        "That's why there is 2D 1 Bit class.",
        "Makanya jadi ada kelas 2D 1 Bit."
    );

    public static readonly LocalizationString UV1_DEVLOG6_4 = new LocalizationString(
        "Because I'm stupid at programming lolololol.",
        "Gegara ngoding gua bego wkwkwk."
    );
    #endregion

    #region DEVLOG 7
    public static readonly LocalizationString UV1_DEVLOG7_0 = new LocalizationString(
        "I was saying that the 3D Humanoid Class has a few characters.",
        "Gua sempet bilang kalau kelas 3D Humanoid karakternya sedikit."
    );

    public static readonly LocalizationString UV1_DEVLOG7_1 = new LocalizationString(
        "I was lying, you're actually the only character from the 3D Humanoid Class.",
        "Sebenernya bukan sedikit sih, tapi lu satu-satunya karakter yang dari kelas 3D Humanoid."
    );
    #endregion

    #region DEVLOG 8
    public static readonly LocalizationString UV1_DEVLOG8_0 = new LocalizationString(
        "Do you know the reason why the 3D Humanoid Class has a few characters?",
        "Tau ga kenapa kelas 3D Humanoid karakternya sedikit?"
    );

    public static readonly LocalizationString UV1_DEVLOG8_1 = new LocalizationString(
        "Because cost is too high.",
        "Karena budget buat bikinnya mahal."
    );

    public static readonly LocalizationString UV1_DEVLOG8_2 = new LocalizationString(
        "Especially the animation, that's why there are a lot of clippings.",
        "Apalagi animasinya, makanya banyak yang clipping."
    );

    public static readonly LocalizationString UV1_DEVLOG8_3 = new LocalizationString(
        "Sigh...",
        "Sigh..."
    );
    #endregion

    #region DEVLOG 9
    public static readonly LocalizationString UV1_DEVLOG9_0 = new LocalizationString(
        "You are on a balcony.",
        "Lu lagi di balkon."
    );

    public static readonly LocalizationString UV1_DEVLOG9_1 = new LocalizationString(
        "And also, you can't open windows.",
        "Dan lu ga bisa buka jendela."
    );

    public static readonly LocalizationString UV1_DEVLOG9_2 = new LocalizationString(
        "Because I'm too lazy to implement a mechanic like that.",
        "Karena emang gua males implementasiin mekanik kayak gitu."
    );

    public static readonly LocalizationString UV1_DEVLOG9_3 = new LocalizationString(
        "Welp, the lore is that the windows have become static objects.",
        "Welp, ceritanya sih jendela tersebut udah jadi objek statis."
    );

    public static readonly LocalizationString UV1_DEVLOG9_4 = new LocalizationString(
        "This means that windows used to be NPCs, but because windows rarely interacted, they turned into static objects.",
        "Ini berarti tadinya jendela itu NPC, terus karena jarang di interact akhirnya mereka jadi objek statis."
    );

    public static readonly LocalizationString UV1_DEVLOG9_5 = new LocalizationString(
        "NPC lore baybe.",
        "Beuh, NPC Lore."
    );
    #endregion

    #region DEVLOG 10
    public static readonly LocalizationString UV1_DEVLOG10_0 = new LocalizationString(
        "The reason why you will not meet any character from 2D Humanoid Class is...",
        "Alesan kenapa lu ga bakalan ketemu karakter dari kelas 2D Humanoid di game ini adalah..."
    );

    public static readonly LocalizationString UV1_DEVLOG10_1 = new LocalizationString(
        "Because I'm too lazy to design their character.",
        "Karena gua males ngedesain karakter-karakter mereka."
    );

    public static readonly LocalizationString UV1_DEVLOG10_2 = new LocalizationString(
        "And it because I'm bad at drawing.",
        "Dan juga karena gua cupu ngegambar."
    );

    public static readonly LocalizationString UV1_DEVLOG10_3 = new LocalizationString(
        "I wanted to just commission it, but because I don't have money, so...",
        "Tadinya mau ngekomis aja, tapi karena ga ada duit jadi..."
    );
    #endregion

    #endregion

    #region UV2
    public static readonly LocalizationString UV2_GUEST = new LocalizationString(
        "This isn't company owner's personal laptop.",
        "Ini bukan laptop personal pemilik perusahaan."
    );

    #region Elefataa
    public static readonly LocalizationString UV2_ELEVATOR_0 = new LocalizationString(
        "Hello! Welcome to the top floor!",
        "Halo! Selamat datang di lantai paling atas!"
    );

    public static readonly LocalizationString UV2_ELEVATOR_1 = new LocalizationString(
        "Where do you want to ride me?",
        "Mau naikki aku ke mana?"
    );

    public static readonly LocalizationString UV2_ELEVATOR_1_1 = new LocalizationString(
        "6th Floor",
        "Lantai 6."
    );

    public static readonly LocalizationString UV2_ELEVATOR_1_2 = new LocalizationString(
        "Cancel.",
        "Gajadi."
    );
    #endregion

    public static readonly LocalizationString UV2_TALK = new LocalizationString(
        "This is probably the company owner's personal laptop, Boba Kotak.",
        "Ini sepertinya laptop personal pemilik perusahaan, Boba Kotak."
    );

    public static readonly LocalizationString UV2_TALK_CHOICES_1 = new LocalizationString(
        "Look at the browsing history.",
        "Cek browsing history - nya."
    );

    public static readonly LocalizationString UV2_TALK_CHOICES_2 = new LocalizationString(
        "Look at board directors meeting recording.",
        "Cek recording rapat board directors."
    );

    public static readonly LocalizationString UV2_TALK_CHOICES_3 = new LocalizationString(
        "Cancel.",
        "Gajadi."
    );

    #region Talk - Browsing History
    public static readonly LocalizationString UV2_TALK_0_0 = new LocalizationString(
        "Checking Boba Kotak's browsing history...",
        "Mengecek browsing history-nya Boba Kotak..."
    );

    public static readonly LocalizationString UV2_TALK_0_1 = new LocalizationString(
        "Boba Kotak likes to open NHenTie site.",
        "Boba Kotak sering membuka situs NekoPie."
    );
    #endregion

    #region Talk - Meeting recording
    public static readonly LocalizationString UV2_TALK_1_0 = new LocalizationString(
        "Checking the board directors meeting recording...",
        "Mengecek recording rapat board directors..."
    );

    public static readonly LocalizationString UV2_TALK_1_1 = new LocalizationString(
        "Welcome my board directors friends.",
        "Selamat datang wahai teman-teman dewan direksi."
    );

    public static readonly LocalizationString UV2_TALK_1_2 = new LocalizationString(
        "Our Plan Z consist of :",
        "Plan Z kita yang berisi :"
    );

    public static readonly LocalizationString UV2_TALK_1_3 = new LocalizationString(
        "1) Without additional salary, exploit all employees to crunch numbers.",
        "1) Buat semua karyawan melembur paksa tanpa digaji lebih."
    );

    public static readonly LocalizationString UV2_TALK_1_4 = new LocalizationString(
        "3) Violates the rights of female workers to reduce cost.",
        "2) Hapus hak-hak pekerja perempuan untuk menghemat budget."
    );

    public static readonly LocalizationString UV2_TALK_1_5 = new LocalizationString(
        "3) Brainwash all 2D 1 Bit and 3D Sphere Robot to always obey us.",
        "3) Memrogram ulang kelas 2D 1 Bit dan 3D Sphere Robot agar selalu mematuhi kita."
    );

    public static readonly LocalizationString UV2_TALK_1_6 = new LocalizationString(
        "Declared successful after 4 years.",
        "Dinyatakan telah berhasil setelah 4 tahun."
    );

    public static readonly LocalizationString UV2_TALK_1_7 = new LocalizationString(
        "In the past 4 years, our income has increased by 1500%.",
        "Dalam kurun waktu 4 tahun ini, pendapatan kita naik 1500%."
    );

    public static readonly LocalizationString UV2_TALK_1_8 = new LocalizationString(
        "Investors are happy with this number.",
        "Investor-investor senang dengan angka ini."
    );

    public static readonly LocalizationString UV2_TALK_1_9 = new LocalizationString(
        "WOOOHOOO YEAAAH BAYBEEE!",
        "WOOOHOOO HEBAT HEBAT!"
    );

    public static readonly LocalizationString UV2_TALK_1_10 = new LocalizationString(
        "MR. KOTAK, YOU'RE JENIUS!",
        "Memang jenius ide Boba Kotak."
    );

    public static readonly LocalizationString UV2_TALK_1_11 = new LocalizationString(
        "Can I ask about spy problem?",
        "Saya mau nanya, masalah spy gimana ya?"
    );

    public static readonly LocalizationString UV2_TALK_1_12 = new LocalizationString(
        "We don't want our practice being exposed to outside of this 3D Titan Sphere Robot.",
        "Kita ga mau apa yang kita lakukan ketahuan di luar 3D Titan Sphere Robot."
    );

    public static readonly LocalizationString UV2_TALK_1_13 = new LocalizationString(
        "Oh, relax!",
        "Oh, tenang saja!"
    );

    public static readonly LocalizationString UV2_TALK_1_14 = new LocalizationString(
        "I already brainwashed all of 2D 1 Bit class and 3D Sphere Robot to catch any spy sneaking here.",
        "Saya sudah program ulang semua kelas 2D 1 Bit dan 3D Sphere Robot untuk menangkap spy yang menyelinap kesini."
    );

    public static readonly LocalizationString UV2_TALK_1_15 = new LocalizationString(
        "Like near Elefataa there's a door that have captcha system that will prevent any spy to get on this floor.",
        "Seperti di dekat Elefataa ada pintu yang punya sistem captcha yang pasti bisa mencegah spy naik ke lantai ini."
    );

    public static readonly LocalizationString UV2_TALK_1_16 = new LocalizationString(
        "WOOOHOOO AWESOME!",
        "WOOOHOOO HEBAT HEBAT!"
    );

    public static readonly LocalizationString UV2_TALK_1_17 = new LocalizationString(
        "Mr. Kotak is just the best.",
        "Gokil sih emang teman kita satu ini."
    );

    public static readonly LocalizationString UV2_TALK_1_18 = new LocalizationString(
        "Can I ask why are we so bad?",
        "Saya mau nanya, kok kita jahat banget ya?"
    );

    public static readonly LocalizationString UV2_TALK_1_19 = new LocalizationString(
        "We're born evil.",
        "Kita memang dari lahir sudah jahat."
    );

    public static readonly LocalizationString UV2_TALK_1_20 = new LocalizationString(
        "HAHAHAHA!",
        "WKWKWKWK!"
    );

    public static readonly LocalizationString UV2_TALK_1_21 = new LocalizationString(
        "This recording can be solid evidence!",
        "Rekaman ini bisa jadi barang bukti yang solid!"
    );

    public static readonly LocalizationString UV2_TALK_1_22 = new LocalizationString(
        "And now what...",
        "Terus abis ini ngepain..."
    );
    #endregion

    #endregion

}
