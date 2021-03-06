package com.sensei.companion.communication.commands;

import android.os.Handler;

abstract class CommandReceiver <T extends Enum<T>> {

    public abstract void interpretCommand (Handler mHandler, String command, String extraInfo);
    public abstract void doCommand (Handler mHandler, T command, String extraInfo);

    public void sendHandlerMessage (Handler mHandler) {
        /*
        boolean handlerSuccess = false;
        if (messageSubject.equals (COMMAND_MESSAGE)) {
            handlerSuccess = mHandler.sendEmptyMessageDelayed(ConnectManager.HandlerMessage.COMMAND_MESSAGE.ordinal(), HANDLER_MESSAGE_DELAY);
        }
        if (!handlerSuccess) {
            Log.d (DEBUG_TAG, "Handler message error");
        } */
    }
}
