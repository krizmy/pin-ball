using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drain : MonoBehaviour
{
    // Collider - это твёрдая оболочка игрового объекта 
    // isTrigger - неосязаемая зона (которую нельзя потрогать) через которую проходят коллайдеры и в случае необходимости эти объекты можно найти при помощи тега
    // Теги - система поиска объектов по имени
    private void OnTriggerEnter(Collider other)// эта функция нужна для того, чтобы отслеживать все объекты с коллайдером, которые
                                               //входят в триггер зону (у объекта на котором находится скрипт и есть компонент Collider и включена галочка isTrigger)
    {
        if (other.gameObject.CompareTag("MainBall"))
        {
            GameManager.BallCount -= 1;
            Debug.Log("Шар попал в ДРЭИН!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainBall"))
        {            
            Debug.Log("Шар вышел из ДРЭИНА!");
        }
    }
}
