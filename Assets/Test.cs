using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���W�ۑ�i�N���X�j
public class Boss
{
    private int hp = 100;        //�̗�
    private int power = 25;  //�U����
    private int mp = 53;        //����

    //�U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    //�h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        //�c��hp�����炷
        this.hp -= damage;
    }

    //���@�p�̊֐�
    public void Magic()
    {
        if(this.mp >= 5)
        {
            //mp5�ȏ�̎�
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }
        else
        {
            //mp������Ȃ���
            Debug.Log("MP������Ȃ��ׁA���@���g���Ȃ��B");
        }
    }
}


public class Test : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        //�ʏ�ۑ�
        //�v�f��5�̔z���������
        int[] array = { 10, 20, 30, 40, 50 };
        //���Ԃɕ\��
        for(int i = 0;i<array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //�t���ɕ\��
        for (int i = 4 ; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //���W�ۑ�
        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //���@�p�̊֐����Ăяo��
        lastboss.Magic();

        //���@��10��g��
        for(int i = 0; i< 10; i++)
        {
            lastboss.Magic();
        }

    }

		// Update is called once per frame
		void Update()
    {
        
    }
}
