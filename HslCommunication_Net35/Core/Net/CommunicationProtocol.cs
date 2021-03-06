﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HslCommunication
{

    /*******************************************************************************
     * 
     *    一个通信辅助类，对通信中的数据做了信号区分
     *
     *    Communications helper classes, the data signal in a communications distinction
     * 
     *******************************************************************************/


    /// <summary>
    /// 用于本程序集访问通信的暗号说明
    /// </summary>
    internal class HslProtocol
    {
        /// <summary>
        /// 规定所有的网络传输指令头都为32字节
        /// </summary>
        internal const int HeadByteLength = 32;

        /// <summary>
        /// 所有网络通信中的缓冲池数据信息
        /// </summary>
        internal const int ProtocolBufferSize = 1024;


        /// <summary>
        /// 用于心跳程序的暗号信息
        /// </summary>
        internal const int ProtocolCheckSecends = 1;
        /// <summary>
        /// 客户端退出消息
        /// </summary>
        internal const int ProtocolClientQuit = 2;
        /// <summary>
        /// 因为客户端达到上限而拒绝登录
        /// </summary>
        internal const int ProtocolClientRefuseLogin = 3;
        /// <summary>
        /// 允许客户端登录到服务器
        /// </summary>
        internal const int ProtocolClientAllowLogin = 4;




        /// <summary>
        /// 说明发送的只是文本信息
        /// </summary>
        internal const int ProtocolUserString = 1001;
        /// <summary>
        /// 发送的数据就是普通的字节数组
        /// </summary>
        internal const int ProtocolUserBytes = 1002;
        /// <summary>
        /// 发送的数据就是普通的图片数据
        /// </summary>
        internal const int ProtocolUserBitmap = 1003;
        /// <summary>
        /// 发送的数据是一条异常的数据，字符串为异常消息
        /// </summary>
        internal const int ProtocolUserException = 1004;




        /// <summary>
        /// 请求文件下载的暗号
        /// </summary>
        internal const int ProtocolFileDownload = 2001;
        /// <summary>
        /// 请求文件上传的暗号
        /// </summary>
        internal const int ProtocolFileUpload = 2002;
        /// <summary>
        /// 请求删除文件的暗号
        /// </summary>
        internal const int ProtocolFileDelete = 2003;
        /// <summary>
        /// 文件校验成功
        /// </summary>
        internal const int ProtocolFileCheckRight = 2004;
        /// <summary>
        /// 文件校验失败
        /// </summary>
        internal const int ProtocolFileCheckError = 2005;
        /// <summary>
        /// 文件保存失败
        /// </summary>
        internal const int ProtocolFileSaveError = 2006;
        /// <summary>
        /// 请求文件列表的暗号
        /// </summary>
        internal const int ProtocolFileDirectoryFiles = 2007;
        /// <summary>
        /// 请求子文件的列表暗号
        /// </summary>
        internal const int ProtocolFileDirectories = 2008;
        /// <summary>
        /// 进度返回暗号
        /// </summary>
        internal const int ProtocolProgressReport = 2009;




        /// <summary>
        /// 不压缩数据字节
        /// </summary>
        internal const int ProtocolNoZipped = 3001;
        /// <summary>
        /// 压缩数据字节
        /// </summary>
        internal const int ProtocolZipped  = 3002;

        
    }


}
