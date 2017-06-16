using System;
using System.ServiceModel;
using WindowsInput;


namespace WCFServer
{
    [ServiceContract()]
    public interface IRemoteService
    {
        // Capture the screen data.
        [OperationContract]
        byte[] UpdateScreenImage();

        // Capture the cursor data.
        [OperationContract]
        void UpdateCursorMove(int x, int y);

        // Capture the cursor event data.
        [OperationContract]
        void UpdateCursorEvent(Win32Stuff.MouseEvents mouseEvent, int x, int y);

        // Capture the keyboard event data.
        [OperationContract]
        void UpdateKeyboardEvent(Win32Stuff.KeyboardEvents keyEvent, VirtualKeyCode vkcode);

        // Login
        [OperationContract]
        Boolean SendLogin(string user, string password);
    }
}