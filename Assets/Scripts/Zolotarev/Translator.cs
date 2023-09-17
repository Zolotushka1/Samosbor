using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Translator : MonoBehaviour
{
    [HideInInspector] public static int LanguageId;
    private static List<Translatable_text> listId = new List<Translatable_text>();

    #region Весь текст

    private static string[,] LineText = // Используем <br> для перехода на след. строку, точно соблюдаем синтаксис
    {
        #region РУССКИЙ 
        {
            "Играть", //0
            "Настройки", //1
            "Выход", //2
            "Выбрать язык",//3
            "Привет! Это тестовый билд нашей игры. Краткое описание сюжета: Вы играете за одного из ликвидаторов последствий самосбора, вас с командой отправляют на задание, но в ходе стычки команды героя и неизвестного монстра, вся ваша команда погибает, вы единственный выживший. Ваша цель - сбежать от монстра и сохранить свою жизнь.", //4
            "Начать игру", //5
            "Назад", //6
            "Почитать про самосбор", //7
            "Настройки графики", //8
            "Сохранить", //9
            "МЕНЮ ПАУЗЫ", //10
            "Продолжить", //11
            "Главное меню", //12
            "Управление", //13
            "Ходить - wasd<br>Бегать - shift + wasd<br>Прыгать - space<br>Красться - ctrl<br>Взаимодействовать - E<br>", //14
            "Нашёл баг? Пиши на почту: xca0@yandex.ru", //15
            "Разрешение экрана", //16
            "Полноэкранный режим", //17
            "Чувствительность мыши", //18
            "Вы умерли", //19
            "Вернуться в меню", //20
            "На этом всё! Спасибо за прохождение тестового билда нашего проекта, обратную связь (или найденные баги и проблемы) можете присылать на почту xca0@yandex.ru" //21
        },
        #endregion

        #region АНГЛИЙСКИЙ
        {
            "Play",
            "Settings",
            "Exit",
            "Set language",
            "Hi! This is a test build of our game. Plot summary: You play as one of the liquidators of the consequences of self-assembly, you and the team are sent on a mission, but during a clash between the hero's team and an unknown monster, your entire team dies, you are the only survivor. Your goal is to escape from the monster and save your life.",
            "Start game",
            "Back",
            "Samosbor FAQ",
            "Graphics Settings",
            "Save",
            "Paused menu",
            "Resume",
            "Main menu",
            "Control",
            "Walk - wasd<br>Run - shift + wasd<br>Jump - space<br>Crouch - ctrl<br>Interact - E",
            "Found a bug? Write to the mail: xca0@yandex.ru",
            "Screen resolution",
            "Fullscreen",
            "Mouse sensitivity",
            "You're dead",
            "Main menu",
            "This is the end! Thank you for passing the test build of our project, you can send feedback (or bugs and problems found) to the mail xca0@yandex.ru"
        },
        #endregion
    };

    #endregion

    static public void Select_language(int id)
    {
        LanguageId = id;
        Update_texts();
    }

    static public string Get_text(int textKey)
    {
        return LineText[LanguageId, textKey];
    }

    static public void Add(Translatable_text idtext)
    {
        listId.Add(idtext);
    }

    static public void Delete(Translatable_text idtext)
    {
        listId.Remove(idtext);
    }

    static public void Update_texts()
    {
        for (int i = 0; i < listId.Count; i++)
        {
            listId[i].UIText.text = LineText[LanguageId, listId[i].textID];
        }
    }
}
