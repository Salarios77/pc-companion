package com.sensei.companion.connection.messages;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;

import com.sensei.companion.proto.ProtoMessage;

public class ProgramInfoMessage extends CMessage {
    private int programId;
    private String programName;
    private Bitmap picture;
    private String programInfo;

    public ProgramInfoMessage (ProtoMessage.CommMessage message) {
        super (message.getMessageId(), message.getMessageType());
        ProtoMessage.CommMessage.ProgramInfo programInfoMessage = message.getProgramInfoMessage();
        this.programId = programInfoMessage.getProgramId();
        this.programName = programInfoMessage.getProgramName();
        this.programInfo = programInfoMessage.getProgramInfo();
        byte [] picBytes = programInfoMessage.getPicture().toByteArray();
        this.picture = BitmapFactory.decodeByteArray(picBytes, 0, picBytes.length);
    }

    public int getProgramId() {
        return programId;
    }

    public void setProgramId(int programId) {
        this.programId = programId;
    }

    public String getProgramName() {
        return programName;
    }

    public void setProgramName(String programName) {
        this.programName = programName;
    }

    public Bitmap getPicture() {
        return picture;
    }

    public void setPicture(Bitmap picture) {
        this.picture = picture;
    }

    public String getProgramInfo() {
        return programInfo;
    }

    public void setProgramInfo(String programInfo) {
        this.programInfo = programInfo;
    }
}
