from __future__ import annotations
from dataclasses import dataclass, field
from kiota_abstractions.serialization import AdditionalDataHolder, Parsable, ParseNode, SerializationWriter
from typing import Any, Callable, Dict, List, Optional, TYPE_CHECKING, Union

if TYPE_CHECKING:
    from .inference_classification_override import InferenceClassificationOverride

@dataclass
class InferenceClassificationOverrideCollectionResponse(AdditionalDataHolder, Parsable):
    # Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.
    additional_data: Dict[str, Any] = field(default_factory=dict)

    # The OdataNextLink property
    odata_next_link: Optional[str] = None
    # The value property
    value: Optional[List[InferenceClassificationOverride]] = None
    
    @staticmethod
    def create_from_discriminator_value(parse_node: Optional[ParseNode] = None) -> InferenceClassificationOverrideCollectionResponse:
        """
        Creates a new instance of the appropriate class based on discriminator value
        Args:
            parseNode: The parse node to use to read the discriminator value and create the object
        Returns: InferenceClassificationOverrideCollectionResponse
        """
        if not parse_node:
            raise TypeError("parse_node cannot be null.")
        return InferenceClassificationOverrideCollectionResponse()
    
    def get_field_deserializers(self,) -> Dict[str, Callable[[ParseNode], None]]:
        """
        The deserialization information for the current model
        Returns: Dict[str, Callable[[ParseNode], None]]
        """
        from .inference_classification_override import InferenceClassificationOverride

        from .inference_classification_override import InferenceClassificationOverride

        fields: Dict[str, Callable[[Any], None]] = {
            "@odata.nextLink": lambda n : setattr(self, 'odata_next_link', n.get_str_value()),
            "value": lambda n : setattr(self, 'value', n.get_collection_of_object_values(InferenceClassificationOverride)),
        }
        return fields
    
    def serialize(self,writer: SerializationWriter) -> None:
        """
        Serializes information the current object
        Args:
            writer: Serialization writer to use to serialize this model
        """
        if not writer:
            raise TypeError("writer cannot be null.")
        writer.write_str_value("@odata.nextLink", self.odata_next_link)
        writer.write_collection_of_object_values("value", self.value)
        writer.write_additional_data_value(self.additional_data)
    

