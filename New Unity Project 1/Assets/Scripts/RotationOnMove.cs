using UnityEngine;
using System.Collections;

public class RotationOnMove : MonoBehaviour {


    public float Max_x_rotation;
    public float Rotation_speed;


    private Transform thisTransform;
    //private Quaternion thisRotation;
  //  private static float Start_x_rot;

    // Use this for initialization
    void Awake () {
        //      Start_x_rot = transform.eulerAngles.x;
        thisTransform = transform;

    }
	
	// Update is called once per frame
	void Update () {

       

       if (Input.GetKey(KeyCode.D))//если нажата кнопка D
        {
     
            thisTransform.Rotate(Vector3.left*Rotation_speed); //повернуть налево (из-за разнонаправленности осей Blender3D и Unity3D "лево" менятся на "право" и наоборот
            if((thisTransform.eulerAngles.x<360-Max_x_rotation)&&(thisTransform.eulerAngles.x>Max_x_rotation))//если угол поворота по оси х принадлежит интервалу (30 до 330)
            {
                thisTransform.eulerAngles = new Vector3(360f - Max_x_rotation, 0, 0); //присвоить 330(максимум поворота)
            }
        }
       
        //аналогично кнопке D
  if(Input.GetKey(KeyCode.A))
        {

            thisTransform.Rotate(Vector3.right*Rotation_speed);
            if (thisTransform.eulerAngles.x > Max_x_rotation && thisTransform.eulerAngles.x < 360 - Max_x_rotation)
            {
                thisTransform.eulerAngles = new Vector3( Max_x_rotation, 0, 0);
            }
        }
        //если не нажаты кнопки поворота влево/вправо, вернуться в исходное положение
  if(!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D))
        {
            thisTransform.rotation = Quaternion.RotateTowards(thisTransform.rotation, new Quaternion(0, 0, 0, 1),Rotation_speed*2.0f);



        }
       


    }
	
 
	}

