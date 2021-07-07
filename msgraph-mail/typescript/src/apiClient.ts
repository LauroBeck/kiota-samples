import {UserRequestBuilder} from './users/item/userRequestBuilder';
import {UsersRequestBuilder} from './users/usersRequestBuilder';
import {HttpCore, HttpMethod, RequestInfo, ResponseHandler, SerializationWriterFactory, registerDefaultSerializers, registerDefaultDeserializers, enableBackingStore, SerializationWriterFactoryRegistry, ParseNodeFactoryRegistry} from '@microsoft/kiota-abstractions';

/** The main entry point of the SDK, exposes the configuration and the fluent API.  */
export class ApiClient {
    /** Current path for the request  */
    public currentPath?: string | undefined;
    /** Core service to use to execute the requests  */
    public httpCore?: HttpCore | undefined;
    /** Path segment to use to build the URL for the current request builder  */
    private readonly pathSegment: string;
    /** Promise to await/call then on for client initialization to be completed.  */
    public readonly registrationMemoize: Promise<void>;
    /** Factory to use to get a serializer for payload serialization  */
    public serializerFactory?: SerializationWriterFactory | undefined;
    public get users(): UsersRequestBuilder {
        const builder = new UsersRequestBuilder();
        builder.currentPath = (this.currentPath ?? '') + this.pathSegment;
        builder.httpCore = this.httpCore;
        builder.serializerFactory = this.serializerFactory;
        return builder;
    }
    /**
     * Instantiates a new Api client and sets the default values.
     * @param httpCore The http core service to use to execute the requests.
     * @param serializationWriterFactory Factory to use to get a serializer for payload serialization.
     */
    public constructor(httpCore: HttpCore | undefined, serializationWriterFactory?: SerializationWriterFactory | undefined) {
        if(!httpCore) throw new Error("httpCore cannot be undefined");
        this.pathSegment = "https://graph.microsoft.com/v1.0";
        httpCore = httpCore;
        this.registrationMemoize = Promise.all([registerDefaultSerializers("@microsoft/kiota-serialization-json/JsonSerializationWriterFactory")]).then(() => Promise.all([registerDefaultDeserializers("@microsoft/kiota-serialization-json/JsonParseNodeFactory")])).then(() => {
            if(!serializationWriterFactory && SerializationWriterFactoryRegistry.defaultInstance.contentTypeAssociatedFactories.size === 0) throw new Error("The Serialization Writer factory has not been initialized for this client.");
            if(!serializationWriterFactory && ParseNodeFactoryRegistry.defaultInstance.contentTypeAssociatedFactories.size === 0) throw new Error("The Parse Node factory has not been initialized for this client.");
            this.serializerFactory = serializationWriterFactory ?? SerializationWriterFactoryRegistry.defaultInstance;
        });
    };
    /**
     * Gets an item from the graphtypescriptv4.utilities.users collection
     * @param id Unique identifier of the item
     * @returns a UserRequestBuilder
     */
    public usersById(id: String) : UserRequestBuilder {
        if(!id) throw new Error("id cannot be undefined");
        const builder = new UserRequestBuilder();
        builder.currentPath = (this.currentPath ?? '') + this.pathSegment + "/users/" + id;
        builder.httpCore = this.httpCore;
        builder.serializerFactory = this.serializerFactory;
        return builder;
    };
}
