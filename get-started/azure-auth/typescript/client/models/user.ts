// tslint:disable
// eslint-disable
// Generated by Microsoft Kiota
import { type AdditionalDataHolder, type Parsable, type ParseNode, type SerializationWriter } from '@microsoft/kiota-abstractions';

export function createUserFromDiscriminatorValue(parseNode: ParseNode | undefined) {
    if(!parseNode) throw new Error("parseNode cannot be undefined");
    return deserializeIntoUser;
}
export function deserializeIntoUser(user: User | undefined = {} as User) : Record<string, (node: ParseNode) => void> {
    return {
        "displayName": n => { user.displayName = n.getStringValue(); },
        "id": n => { user.id = n.getStringValue(); },
    }
}
export function serializeUser(writer: SerializationWriter, user: User | undefined = {} as User) : void {
        writer.writeStringValue("displayName", user.displayName);
        writer.writeStringValue("id", user.id);
        writer.writeAdditionalData(user.additionalData);
}
export interface User extends AdditionalDataHolder, Parsable {
    /**
     * Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.
     */
    additionalData?: Record<string, unknown>;
    /**
     * The displayName property
     */
    displayName?: string;
    /**
     * The id property
     */
    id?: string;
}
// tslint:enable
// eslint-enable
